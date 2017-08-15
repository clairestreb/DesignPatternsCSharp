using System;
using System.Collections.Generic;
using System.Reflection;

namespace Domain.FactoryPatterns
{
    public class MachineFactory
    {
        Dictionary<string, Type> machines;

        public MachineFactory()
        {
            LoadTypesICanReturn();
        }

        public IMachine CreateInstance(string description)
        {
            Type t = GetTypeToCreate(description);

            if (t == null)
                return new UnknownMachine();

            return Activator.CreateInstance(t) as IMachine;
        }

        private Type GetTypeToCreate(string machineName)
        {
            foreach (var machine in machines)
            {
                if (machine.Key.Contains(machineName))
                {
                    return machines[machine.Key];
                }
            }

            return null;
        }

        private void LoadTypesICanReturn()
        {
            machines = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IMachine).ToString()) != null)
                {
                    machines.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}