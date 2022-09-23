using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    public class Student:Persona
    {
        public string program { get; set; }
        public int year { get; set; }
        public double fee { get; set; }

        public Student(string name, string address,string program, int year, double fee): base(name,address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public override string ToString()
        {
            return $"Estudiante: {name} direccion: {address} programa: {program} año: {year} matricula {fee}";
        }
    }
}
