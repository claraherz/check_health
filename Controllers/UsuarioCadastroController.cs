
﻿using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    public class UsuarioCadastroController
    {
        public static Response CheckerInsert(UsuarioCadastro user)
        {
            if (!string.IsNullOrEmpty(user.Nome) && user.Nome.Length < 51)
            {
                if (!string.IsNullOrEmpty(user.Email) && user.Email.Length < 51)
                {
                    if (!string.IsNullOrEmpty(user.Senha) && user.Senha.Length < 51)
                    {
                        return UsuarioCadastroBD.Insert(user);
                    }
                    else
                    {
                        return new Response
                        {
                            Executed = false,
                            ErrorMessage = "Senha num padrão incorreto"
                        };
                    }
                }
                else
                {
                    return new Response
                    {
                        Executed = false,
                        ErrorMessage = "E-mail num padrão incorreto"
                    };
                }
            }
            else
            {
                return new Response
                {
                    Executed = false,
                    ErrorMessage = "Nome num padrão incorreto"
                };
            }
        }

        public static Response CheckerSelect(string email, string senha, out UsuarioCadastro user)
        {
            user = new UsuarioCadastro();

            if (!string.IsNullOrEmpty(email) && email.Length < 51)
            {
                if (!string.IsNullOrEmpty(senha) && senha.Length < 51)
                {
                    return UsuarioCadastroBD.Select(email, senha, out user);
                }
                else
                {
                    return new Response
                    {
                        Executed = false,
                        ErrorMessage = "Senha está incorreta"
                    };
                }
            }
            else
            {
                return new Response
                {
                    Executed = false,
                    ErrorMessage = "E-mail está incorreto"
                };
            }

        }
    }
}
