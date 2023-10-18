﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Modelo;

public class UsuarioValidation
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
}
