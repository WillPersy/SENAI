using back_aula.Interface;
using back_aula.Classes;

namespace back_aula.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
       
    }
}