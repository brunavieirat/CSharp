using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cep
{
    class Util
    {

        public Endereco BuscaCep(string cep)
        {
            Endereco endereco= new Endereco();

            try
            {

                DataSet dataSet = new DataSet();

                //Obtem o XML do Webservice

                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep);

                //dataset le xml

                dataSet.ReadXml(xml);

                endereco.TipoLogradouro= dataSet.Tables[0].Rows[0]["tipo_logradouro"].ToString();

                endereco.Logradouro = endereco.TipoLogradouro + " "+ dataSet.Tables[0].Rows[0]["logradouro"].ToString();
                endereco.Cidade = dataSet.Tables[0].Rows[0]["cidade"].ToString();
                endereco.Bairro = dataSet.Tables[0].Rows[0]["bairro"].ToString();
                endereco.UF = dataSet.Tables[0].Rows[0]["uf"].ToString();

                


            }
            catch (Exception ex)
            {
                string msg = "Erro ";
                string titulo = "erro";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return endereco;
        }


    }
}
