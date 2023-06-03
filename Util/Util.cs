using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public static class Util
{
    public static Dictionary<object, object> JsonToDict(string jsonPath)
    {
        string json = System.IO.File.ReadAllText(jsonPath);

        Dictionary<object, object> dict = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);

        return dict;
    }

    public static string ApenasNumeros(string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }


    public static bool IsCpfValido(string cpf)
    {
        cpf = ApenasNumeros(cpf);

        // Verificar se o CPF possui 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Verificar se todos os dígitos são iguais
        bool todosDigitosIguais = cpf.Distinct().Count() == 1;
        if (todosDigitosIguais)
        {
            return false;
        }

        // Calcular o primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }
        int resto = soma % 11;
        int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

        // Verificar se o primeiro dígito verificador está correto
        if (digitoVerificador1 != int.Parse(cpf[9].ToString()))
        {
            return false;
        }

        // Calcular o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }
        resto = soma % 11;
        int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

        // Verificar se o segundo dígito verificador está correto
        if (digitoVerificador2 != int.Parse(cpf[10].ToString()))
        {
            return false;
        }

        return true;
    }

    public static bool IsCnpjValido(string cnpj)
    {
        // Remover caracteres não numéricos do CNPJ
        cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

        // Verificar se o CNPJ possui 14 dígitos
        if (cnpj.Length != 14)
        {
            return false;
        }

        // Calcular o primeiro dígito verificador
        int soma = 0;
        int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        for (int i = 0; i < 12; i++)
        {
            soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];
        }
        int resto = soma % 11;
        int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

        // Verificar se o primeiro dígito verificador está correto
        if (digitoVerificador1 != int.Parse(cnpj[12].ToString()))
        {
            return false;
        }

        // Calcular o segundo dígito verificador
        soma = 0;
        int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        for (int i = 0; i < 13; i++)
        {
            soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];
        }
        resto = soma % 11;
        int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

        // Verificar se o segundo dígito verificador está correto
        if (digitoVerificador2 != int.Parse(cnpj[13].ToString()))
        {
            return false;
        }

        // CNPJ é válido
        return true;
    }

}
