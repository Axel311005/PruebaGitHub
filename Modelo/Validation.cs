﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Modelo;
using System.Text.RegularExpressions;

public class Validation                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
{
    public static List<string> ValidarUsuario(Usuario usuario)
    {
        var resultadosValidacion = new List<ValidationResult>();
        var contexto = new ValidationContext(usuario, serviceProvider: null, items: null);
        var errores = new List<string>();

        if (!Validator.TryValidateObject(usuario, contexto, resultadosValidacion, validateAllProperties: true))
        {
            foreach (var resultado in resultadosValidacion)
            {
                errores.Add(resultado.ErrorMessage);
            }
        }

        return errores;
    } 
    public static List<string> ValidarEmpleado(Empleado empleado)
    {
        var resultadosValidacion = new List<ValidationResult>();
        var contexto = new ValidationContext(empleado, serviceProvider: null, items: null);
        var errores = new List<string>();

        if (!Validator.TryValidateObject(empleado, contexto, resultadosValidacion, validateAllProperties: true))
        {
            foreach (var resultado in resultadosValidacion)
            {
                errores.Add(resultado.ErrorMessage);
            }
        }

        return errores;
    }

    public static bool ContadorIntentos(int intentosFallidos)
    {
        if (intentosFallidos >= 10)
            return true;
        else
            return false;
    }

    public static string FormatearCedula(string cedula)
    {
        cedula = cedula.Replace("-", "");

        if (Regex.IsMatch(cedula, @"^\d{11}[A-Z]$"))
        {
            cedula = $"{cedula.Substring(0, 3)}-{cedula.Substring(3, 6)}-{cedula.Substring(9, 4)}{cedula.Substring(13)}";
        }

        return cedula;
    }

    public static string FormatearNumeroINSS(string numeroINSS)
    {
        numeroINSS = numeroINSS.Replace("-", "");

        if (Regex.IsMatch(numeroINSS, @"^\d{7}\d{1}$"))
        {
            numeroINSS = $"{numeroINSS.Substring(0, 7)}-{numeroINSS.Substring(7)}";
        }

        return numeroINSS;
    }

    public static List<string> ValidarCargo(Cargo cargo)
    {
        var resultadosValidacion = new List<ValidationResult>();
        var contexto = new ValidationContext(cargo, serviceProvider: null, items: null);
        var errores = new List<string>();

        if (!Validator.TryValidateObject(cargo, contexto, resultadosValidacion, validateAllProperties: true))
        {
            foreach (var resultado in resultadosValidacion)
            {
                errores.Add(resultado.ErrorMessage);
            }
        }

        return errores;
    }

    public static List<string> ValidarComision(Comisiones comisiones)
    {
        var resultadosValidacion = new List<ValidationResult>();
        var contexto = new ValidationContext(comisiones , serviceProvider: null, items: null);
        var errores = new List<string>();

        if (!Validator.TryValidateObject(comisiones, contexto, resultadosValidacion, validateAllProperties: true))
        {
            foreach (var resultado in resultadosValidacion)
            {
                errores.Add(resultado.ErrorMessage);
            }
        }

        return errores;
    }
}
