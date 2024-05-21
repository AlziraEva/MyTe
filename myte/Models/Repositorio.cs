namespace myte.Models
{
    public class Repositorio
    {
        private static List<Departamento> _todosOsDepartamentos = new List<Departamento>();

        public static IEnumerable<Departamento> TodosOsDepartamentos
        {
            get { return _todosOsDepartamentos; }
        }

        public static void Inserir(Departamento registroDepartamento)
        {
            _todosOsDepartamentos.Add(registroDepartamento);
        }

        public static void Excluir(Departamento Registrodepartamento)
        {
            _todosOsDepartamentos.Remove(Registrodepartamento);
        }
    }
}
