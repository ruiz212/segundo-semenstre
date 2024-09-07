
public class ProduccionSA
{
    public string Nombre;
    public string Puesto;
    public string Departamento;
    private decimal _Salario;



    public ProduccionSA(string nombre, string puesto, string departamento, decimal Salario)
    {
        Nombre = nombre;
        Puesto = puesto;
        Departamento = departamento;
        _Salario = Salario;
    }
    public string nombre { get; set; }
    public string puesto { get; set; }
    public string departamento { get; set; }
    public decimal Salario
    {
        get { return _Salario; }
        set { _Salario = value; }
    }



}
    

