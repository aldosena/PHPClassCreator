using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gerador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class Global
        {
            // esta é uma classe public e todas as variáveis aqui passa a ser publica tambem
            public static string Versao = "2.0 - 17 / 12 / 2023";
            public static string vLinha; // faz a leitura dos campos
            public static string vS; // para uso geral
            public static int vTotCampo; // total de campos da tabela para um laço for
        }// public
        public string CampoMy(string s)
        {
            s = s.Trim();
            string Verbo = "";
            int Posicao1 = 0; // p inicial 
            int Posicao2 = 0; // p final
            Posicao1 = s.IndexOf('`'); // p1
            string Resto = s.Substring(Posicao1 + 1);  // resto
            Posicao2 = Resto.IndexOf('`'); // p2 
            if (Posicao2 > 0)
            {
                Verbo = Resto.Substring(0, Posicao2);
            }// tem p2
            return Verbo;
        }

        private void MyFu()
        {
            // esta é uma funçao de teste para aprender
            // this.BackColor = Color.Red;
            MessageBox.Show("Executado");
        }

        private void Fu_ClasseEscola()
        {
            txEscola.Text = ""; // limpar
            txEscola.Text = "<?php";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "# referente a tabela " + txTabela.Text;
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);
            //
            txEscola.Text = txEscola.Text + "// namespace " + txNamespace.Text + ";";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "// use \\PDO;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "# exemplo de uso: include_once \"src/assets/conect.php\";";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "# exemplo de uso: use src\\Model\\Turma;";

            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "class " + txClasse.Text;
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "{";
            txEscola.AppendText(Environment.NewLine);

            // campos - - --
            txEscola.Text = txEscola.Text + txFields.Text; // *
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);
            //
            // contructor
            txEscola.Text = txEscola.Text; // *
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);

            //select
            txEscola.Text = txEscola.Text + "/** ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * Exibe todos os registros ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @param int $esco id da escola";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @return bool true ou false";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "*/ ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "   public function selectAll(int $esco)";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "   {";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "       $sql = \"SELECT * FROM " + txTabela.Text + " WHERE KEY = ?? ORDER BY ?? \";";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "       $stmt = $this->pdo->prepare($sql);";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "       $stmt->execute();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "       $data = $stmt->fetchAll(PDO::FETCH_ASSOC);";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "       return $data;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "   }";
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);

            // byId
            txEscola.Text = txEscola.Text + "/** ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * Exibe dados do id escolhido";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @param int $kod codigo do registro";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @return bool 1 true ou 0 false";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "*/ ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  public function selectById(int $kod)";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  {";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  $sql = \"SELECT * FROM " + txTabela.Text + " WHERE " + txIndex.Text + " = \"" + " . " +  "$kod;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  $stmt = $this->pdo->prepare($sql);";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  $stmt->execute();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  if ($stmt->rowCount() > 0){";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $li = $stmt->fetch(PDO::FETCH_ASSOC);";
            txEscola.AppendText(Environment.NewLine);

            foreach (string linha in txCampos.Lines)
            {
                if (linha.Trim() != "")
                {
                    txEscola.Text = txEscola.Text + "    $this->" + linha + " = $li['" + linha + "'];";
                    txEscola.AppendText(Environment.NewLine);
                };// se tem texto
            };// foreach
     //       txEscola.Text = txEscola.Text + "    $this->Rtotal = 1;"; // delete isso
      //      txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    return true;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  }else{";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    return false;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  }  // if";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "}";
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);

            // insert  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            txEscola.Text = txEscola.Text + "/** Inserir registro na tabela";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "* @param int $esco id ada escola";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "* @return int ultimo insert";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " */";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  public function insert(int $esco)";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  {";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $sql = \"INSERT INTO " + txTabela.Text + "(";
            // pegar todos os campo EXCETO O PRIMEIRO
            for (int i = 1; i < Global.vTotCampo; i++)
            {
                txEscola.Text = txEscola.Text + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o últim ocampo
                {
                    txEscola.Text = txEscola.Text + ", ";
                }
            }
            txEscola.Text = txEscola.Text + ")VALUES(";
            for (int i = 1; i < Global.vTotCampo; i++)
            {
                txEscola.Text = txEscola.Text + ":" + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o último campo
                {
                    txEscola.Text = txEscola.Text + ", ";
                }
            }
            txEscola.Text = txEscola.Text + ")\";";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $stmt = $this->pdo->prepare($sql);";
            txEscola.AppendText(Environment.NewLine);
            // laço
            //foreach (string linha in txCampos.Lines)
            for (int i = 1; i < Global.vTotCampo; i++)
            {
                txEscola.Text = txEscola.Text + "    $stmt->bindValue(':" + txCampos.Lines[i] + "', $this->" + txCampos.Lines[i] + ");";
                txEscola.AppendText(Environment.NewLine);
            }
            txEscola.Text = txEscola.Text + "    $stmt->execute();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    return  $this->pdo->lastInsertId();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  }";
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);
            // fim do insert

            // update  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            txEscola.Text = txEscola.Text + "/** ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * Atualizar registros ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @param int $kod id do registro";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @return bool 0 ou um da tabela";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "*/ ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  public function update(int $kod)";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  {";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $sql = \"UPDATE " + txTabela.Text + " SET ";
            // pegar todos os campo
            for (int i = 1; i < Global.vTotCampo; i++)
            {
                txEscola.Text = txEscola.Text + txCampos.Lines[i] + "= :"; // escrever o campo
                txEscola.Text = txEscola.Text + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o último campo
                {
                    txEscola.Text = txEscola.Text + ", ";
                }
            }
            txEscola.Text = txEscola.Text + " WHERE " + txIndex.Text + " = \"" + " . " +  "$kod;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $stmt = $this->pdo->prepare($sql);";
            txEscola.AppendText(Environment.NewLine);
           // foreach (string linha in txCampos.Lines)
           for (int i = 1; i < Global.vTotCampo; i ++) // pula o primeiro
            {
                //txEscola.Text = txEscola.Text + "    $stmt->bindValue(':" + linha + "', $this->" + linha + ");";
                txEscola.Text = txEscola.Text + "    $stmt->bindValue(':" + txCampos.Lines[i]  + "', $this->" + txCampos.Lines[i] + ");";
                txEscola.AppendText(Environment.NewLine);
            }
            txEscola.Text = txEscola.Text + "    $stmt->execute();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    return true;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  }";
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);

            // delete  - - - - - -  - - - - - -  - - - - - -  - - - - - -  - - - - - -  - - - - - - 
            txEscola.Text = txEscola.Text + "/** ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * Excluir registro ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @param int $kid para deletar";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + " * @return bool true ou false";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "*/ ";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  public function delete(int $kid)";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  {";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $sql = \"DELETE FROM " + txTabela.Text + " WHERE " + txIndex.Text + " = \"" + " . " + "$kid;";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    $stmt = $this->pdo->prepare($sql);";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "    return $stmt->execute();";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "  }";
            txEscola.AppendText(Environment.NewLine);
            txEscola.AppendText(Environment.NewLine);
            // fim do arquivo
            txEscola.Text = txEscola.Text + "}  // fim da classe";
            txEscola.AppendText(Environment.NewLine);
            txEscola.Text = txEscola.Text + "?>";
        } // fim da classe escola

        private void Fu_ClasseGrauDao()
        {
            int CampoKonta = 0;
            string CampoNome = "";
            string Interroga = "";
            // classe dao do Grau
            txDao.Text = ""; // limpar
            txDao.Text = "<?php";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "# Referente a tabela " + txTabela.Text;
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "namespace " + txNamespace.Text + "\\" + "DAO;";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "use " + txNamespace.Text + "\\" + "Model" + "\\" + txClasse.Text + "Model;";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "use " + "\\" + "PDO;";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "class " + txClasse.Text + "DAO extends DAO";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "{";
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + "  public function __construct() \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  { \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "    parent::__construct(); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  } \n";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + " public function selectAll() \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " { \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "   $sql = \"SELECT * FROM " + txTabela.Text + "\";";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "   $stmt = $this->conexao_XXX->prepare($sql); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "   $stmt->execute(); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "   return $stmt->fetchAll(PDO::FETCH_ASSOC); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " }\n";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + " public function selectById(int $id) \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " { \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $sql = \"SELECT * FROM " + txTabela.Text + " where id = ?\"; \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $stmt = $this->conexao_XXX->prepare($sql); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $stmt->bindValue(1, $id); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $stmt->execute(); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  return $stmt->fetch(PDO::FETCH_ASSOC); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " } \n";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);

            // insert na dao
            // laço para pegar os campos
            foreach (string linha in txCampos.Lines)
            {
                if (linha != "")
                {
                    CampoNome = CampoNome + ", " + linha;
                    Interroga = Interroga + ", ?";
                    CampoKonta = CampoKonta + 1;
                };// linha nao vazio
            }

            txDao.Text = txDao.Text + " public function insert($model) \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " { \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $sql = \"INSERT INTO " + txTabela.Text + "(" + CampoNome + ")VALUES(" + Interroga + ")\"; \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  $stmt = $this->" + txConexao.Text + "->prepare($sql); \n";
            txDao.AppendText(Environment.NewLine);

            // laço para pegar os campos e colocar os gets
            CampoKonta = 1;
            foreach (string linha in txCampos.Lines)
            {
                if (linha != "")
                {
                    txDao.Text = txDao.Text + "  $stmt->bindValue(" + CampoKonta + ", $model->get_" + linha + "()); \n";
                    txDao.AppendText(Environment.NewLine);
                    CampoKonta = CampoKonta + 1;
                };// linha nao vazio
            }

            txDao.Text = txDao.Text + "  return $stmt->execute(); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + " } \n";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + "  public function update($model) \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  { \n";
            txDao.AppendText(Environment.NewLine);
            // pegar o nome dos campos
            CampoNome = "";
            foreach (string xCampo in txCampos.Lines)
            {
                if (xCampo != "")
                {
                    CampoNome = CampoNome + ", " + xCampo + "=?";
                }; //if
            } // foreach

            txDao.Text = txDao.Text + "    $sql = \"UPDATE " + txTabela.Text + " SET " + CampoNome + " WHERE " + txIndex.Text + " = ?\"; \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "    $stmt = $this->" + txConexao.Text + "->prepare($sql); \n";
            txDao.AppendText(Environment.NewLine);

            // loop
            CampoKonta = 1;
            foreach (string xCampo in txCampos.Lines)
            {
                if (xCampo != "")
                {
                    //CampoNome = CampoNome + ", " + xCampo + "=?";
                    txDao.Text = txDao.Text + "    $stmt->bindValue(1,$model->get_" + xCampo + "()); \n";
                    txDao.AppendText(Environment.NewLine);
                    CampoKonta = CampoKonta + 1;
                }; //if
            } // foreach
            // fim loop

            txDao.Text = txDao.Text + "    return $stmt->execute(); \n";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "  } \n";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + " public function delete($id) \n";
            txDao.Text = txDao.Text + " { \n";
            txDao.Text = txDao.Text + "  $sql = 'DELETE FROM " + txTabela.Text + " WHERE id = ?'; \n";
            txDao.Text = txDao.Text + "  $stmt = $this->conexao_XXX->prepare($sql); \n";
            txDao.Text = txDao.Text + "  $stmt->bindValue(1, $id); \n";
            txDao.Text = txDao.Text + "  return $stmt->execute(); \n";
            txDao.Text = txDao.Text + " } \n";

            txDao.Text = txDao.Text + "} // class";
            txDao.AppendText(Environment.NewLine);
        }

        private void Fu_ClasseGrauModel()
        {
            txModel.Text = "<?php";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "# Referente a tabela" + txTabela.Text;
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "namespace src" + "\\" + "Model;";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "use src" + "\\" + "DAO" + "\\" + txClasse.Text + "DAO;";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "class " + txClasse.Text;
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "{";
            txModel.AppendText(Environment.NewLine);

            // campos
            txModel.Text = txModel.Text + txFields.Text; // conteúdo
            txModel.AppendText(Environment.NewLine);// pula linha
            // se responser estiver marcado ...
            txModel.Text = txModel.Text + "public $response; // p pesquisa";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            // getts e setts ---------------------------------------------
            txModel.Text = txModel.Text + "// - -  gets and sets  - - - - - - ";
            txModel.AppendText(Environment.NewLine);

            foreach (string linha in txCampos.Lines)
            {
                // txModel.Text = txModel.Text + linha + "\n";
                txModel.Text = txModel.Text + " public function get_" + linha + "(){";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + "   return $this->" + linha + ";";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " }";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " public function set_" + linha + "($x){";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + "   $this->" + linha + " = $x;";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " }";
                txModel.AppendText(Environment.NewLine);
            }
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "// functions - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + " public function getAll()";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $this->response = json_encode($dao->selectAll(), JSON_UNESCAPED_UNICODE);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + " public function getById($id)";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  $this->response = $dao->selectById($id);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "public function add($post) // receb o post do formulário";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "{";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$response = []; // cria o array";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$dao = new RelatoresDAO();";
                txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$this->set_relatornome($post['relatornome']); // passa os dado q recebeu do formulário";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$this->set_uf($post['uf']);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$response['status'] = $dao->insert($this); // dentro do array, vai ser o 'status'";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$this->response = json_encode($response, JSON_UNESCAPED_UNICODE); // passa o array com responsta";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "}";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "  public function update($post) \n";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "    $resp = [];";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $dao = new " + txClasse.Text + "DAO($post);";
            txModel.AppendText(Environment.NewLine);

            // loop
            foreach (string sCampo in txCampos.Lines)
            {
                txModel.Text = txModel.Text + "   $this->set_" + sCampo + "($post[\'" + sCampo + "\']);";
                txModel.AppendText(Environment.NewLine);
            }

            // fim loop
            txModel.Text = txModel.Text + "    $resp[\'status\'] = $dao->update($this);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "    $this->response = json_encode($resp,JSON_UNESCAPED_UNICODE);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "  public function delete($id)";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$resp = [];";
            txModel.Text = txModel.Text + "     $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "$resp['status'] = $dao->delete($id); // dentro do array, vai ser o 'status'";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "} // class";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "?> \n";

        }

        private void Fu_ClasseGrauController()
        {
            txController.Text = "<?php";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "# Referente a tabela: " + txTabela.Text + " \n";
            txController.AppendText(Environment.NewLine);// pula linha
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "namespace " + txNamespace.Text + "\\Controller;";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "use " + txNamespace.Text + "\\" + "Model" + "\\" + txClasse.Text + ";";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "class " + txClasse.Text + "Controller extends Controller";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "{";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);// pula linha

            txController.Text = txController.Text + " public static function index() \n";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + " {";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "   parent::has_user();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "   parent::load_page('" + txClasse.Text + "//" + "index');";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + " }";
            txController.AppendText(Environment.NewLine);// pula linha

            txController.Text = txController.Text + "  public static function add()";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  {";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model = new " + txClasse.Text + "Model();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model->add($_POST); // receb o post do formulário";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    echo $model->response;";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  }";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "  public static function getAll()";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    {";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model = new txClasse.Text + Model();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model->getAll();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    echo $model->response;";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  }";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "  public static function getById()";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $k = intval($_GET['id']);";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model = new txClasse.Text + Model();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model->getById($k);";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    echo $model->response;";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  }";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "  public static function update()";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  {";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model = new " + txClasse.Text + "Model();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model->update($_POST); // recebe do form";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    echo $model->response;";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  }";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "  public static function delete()";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  {";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $k = intval($_GET['id']);";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    $model = new txClasse.Text + Model();";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "    echo $model->delete($k);";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "  }";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);

            // campos
            foreach (string linha in txCampos.Lines)
            {
                txController.Text = txController.Text + linha + "\n";
                txController.AppendText(Environment.NewLine);
            }
            txController.Text = txController.Text + "} // class";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "?>";
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            txAviso.Text = "";
            txAviso.BackColor  = Color.White;
            Global.vTotCampo = txCampos.Lines.Length;
            if (txClasse.Text == "")
            {
                txAviso.Text = "Escreva o nome da classe";
                txAviso.BackColor = Color.Yellow;
                return;
            }
            if (txNamespace.Text == "")
            {
                txAviso.Text = "Digite o Diretório do Namesapce";
                txAviso.BackColor = Color.Yellow;
                return;
            }
            if (txTabela.Text == "")
            {
                txAviso.Text = "Informe o nome da tabela relacionada a Classe";
                txAviso.BackColor = Color.Yellow;
                return;
            }

            // txFields  - - - - - - - - - - - - - - - - - - 
            string vprivate = "public";
            if (cbPrivado.Checked){ vprivate = "private"; }
            txFields.Text = "";
            if (cbPdo.Checked)
            {
                txFields.Text = txFields.Text + "   private $pdo;";
                txFields.AppendText(Environment.NewLine);
            };
            int Inteiro = 0;
            string Sinteiro = string.Empty;
            foreach (string linha in txCampos.Lines)
            {
                if (linha.Trim() != "") // só inserer se houver dados na linha
                {
                    if (Inteiro == 0) { Sinteiro = " int"; } else { Sinteiro = ""; };
                    txFields.Text = txFields.Text + "   " + vprivate + Sinteiro + " $" + linha + ";";
                    txFields.AppendText(Environment.NewLine);
                };
                ++Inteiro;
            };

            // indice  - - - - - - - - - - - - 
            txIndex.Text = txCampos.Lines[0];

            // Model - - - - - - -- - - - - - - - - - - 
            if (cbGrauModel.Checked)
            {
                Fu_ClasseGrauModel();
            }            


        } // click on button

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to execute this method?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyFu();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txAviso.Text = txAviso.Text + "Versao: " + Global.Versao;
            txAviso.AppendText(Environment.NewLine);
            txAviso.Text = txAviso.Text + "Diretório:";
            txAviso.AppendText(Environment.NewLine);
            string Rua = System.Environment.CurrentDirectory;
            txAviso.Text = txAviso.Text + Rua;
            txAviso.AppendText(Environment.NewLine);
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbLimpaMy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpar texto do MySql ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txMy.Text = "";
            }
        }

        private void lbLimpaCampos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpar a lista de Campos da Tabela ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txCampos.Text = "";
            }
        }

        private void btMysql_Click(object sender, EventArgs e)
        {
            // pega o conteudo do txMy (mysql) e cria os campos das classes
            txCampos.Text = "";
            // pegar o texto que etiver dentro de
            foreach (string linha in txMy.Lines)
            {
                string rs = CampoMy(linha);
                    txCampos.Text = txCampos.Text + rs;
                    txCampos.AppendText(Environment.NewLine);
            }
        }

        private void btGetsSets_Click(object sender, EventArgs e)
        {
        }

        private void btCrud_Click(object sender, EventArgs e)
        {
            // serve para inserir os métidos básicos
            txMeto.Text = "";
            //select
            txMeto.Text = txMeto.Text + "  public function selectAll($es)";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  {";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $sql = \"SELECT * FROM " + txTabela.Text + " WHERE escola = \"" + " . " + "$es;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $stmt = $this->pdo->prepare($sql);";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $stmt->execute();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $data = $stmt->fetchAll(PDO::FETCH_ASSOC);";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  return $data;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }";
            txMeto.AppendText(Environment.NewLine);
            txMeto.AppendText(Environment.NewLine);

            // byId
            txMeto.Text = txMeto.Text + "  public function selectById($ki)";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  {";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $sql = \"SELECT * FROM " + txTabela.Text + " WHERE " + txIndex.Text + " = \"" + " . " + "$ki;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $stmt = $this->pdo->prepare($sql);";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  $stmt->execute();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  if ($stmt->rowCount() > 0){";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $li = $stmt->fetch(PDO::FETCH_ASSOC);";
            txMeto.AppendText(Environment.NewLine);

            foreach (string linha in txCampos.Lines)
            {
                txMeto.Text = txMeto.Text + "    $this->" + linha + " = $li['" + linha + "'];";
                txMeto.AppendText(Environment.NewLine);
            }
            txMeto.Text = txMeto.Text + "    $this->Rtotal = 1;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    return true;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }else{";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    return false;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }  // if";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "}";
            txMeto.AppendText(Environment.NewLine);
            txMeto.AppendText(Environment.NewLine);

            // insert  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            txMeto.Text = txMeto.Text + "  public function insert()";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  {";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $sql = \"INSERT INTO " + txTabela.Text + "(";
            // pegar todos os campo
            for (int i = 0; i < Global.vTotCampo; i++)
            {
                txMeto.Text = txMeto.Text + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o últim ocampo
                {
                    txMeto.Text = txMeto.Text + ", ";
                }
            }
            txMeto.Text = txMeto.Text + ")VALUES(";
            for (int i = 0; i < Global.vTotCampo; i++)
            {
                txMeto.Text = txMeto.Text + ":" + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o último campo
                {
                    txMeto.Text = txMeto.Text + ", ";
                }
            }
            txMeto.Text = txMeto.Text + ")\";";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $stmt = $this->pdo->prepare($sql);";
            txMeto.AppendText(Environment.NewLine);
            // laço
            foreach (string linha in txCampos.Lines)
            {
                txMeto.Text = txMeto.Text + "    $stmt->bindValue(':" + linha + "', $this->" + linha + ");";
                txMeto.AppendText(Environment.NewLine);
            }
            txMeto.Text = txMeto.Text + "    $stmt->execute();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    return  $this->pdo->lastInsertId();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }";
            txMeto.AppendText(Environment.NewLine);
            txMeto.AppendText(Environment.NewLine);
            // fim do insert

            // update  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            txMeto.Text = txMeto.Text + "  public function update($ki)";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  {";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $sql = \"UPDATE " + txTabela.Text + " SET ";
            // pegar todos os campo
            for (int i = 0; i < Global.vTotCampo; i++)
            {
                txMeto.Text = txMeto.Text + txCampos.Lines[i] + "= :"; // escrever o campo
                txMeto.Text = txMeto.Text + txCampos.Lines[i]; // escrever o campo
                if (i < (Global.vTotCampo - 1)) // se nao for o último campo
                {
                    txMeto.Text = txMeto.Text + ", ";
                }
            }
            txMeto.Text = txMeto.Text + " WHERE " + txIndex.Text + " = \"" + " . " + "$ki;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $stmt = $this->pdo->prepare($sql);";
            txMeto.AppendText(Environment.NewLine);
            foreach (string linha in txCampos.Lines)
            {
                txMeto.Text = txMeto.Text + "    $stmt->bindValue(':" + linha + "', $this->" + linha + ");";
                txMeto.AppendText(Environment.NewLine);
            }
            txMeto.Text = txMeto.Text + "    $stmt->execute();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    return true;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }";
            txMeto.AppendText(Environment.NewLine);
            txMeto.AppendText(Environment.NewLine);

            // delete  - - - - - -  - - - - - -  - - - - - -  - - - - - -  - - - - - -  - - - - - - 
            txMeto.Text = txMeto.Text + "  public function delete($ki)";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  {";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $sql = \"DELETE FROM " + txTabela.Text + " WHERE " + txIndex.Text + " = \"" + " . " + "$ki;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $stmt = $this->pdo->prepare($sql);";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    $stmt->execute();";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "    return true;";
            txMeto.AppendText(Environment.NewLine);
            txMeto.Text = txMeto.Text + "  }";
            txMeto.AppendText(Environment.NewLine);
            txMeto.AppendText(Environment.NewLine);

        }

        private void btPegaParaDAO_Click(object sender, EventArgs e)
        {
            BoxCamposDao.Items.Clear();
            foreach (string linha in txCampos.Lines)
            {
                BoxCamposDao.Items.Add(linha);
            }
        }

        private void btPegaCampoParaForm_Click(object sender, EventArgs e)
        {
        }

        private void btCriarForm_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fu_ClasseEscola();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btFilterFilds_Click(object sender, EventArgs e)
        {
            // pega os campos vindo do PhpMyAdmin
            txCampos.Text = ""; // limpar
            // criar uma unica linha com os dados
            string Mega = "";
            foreach (string linha in txMy.Lines)
            {
                Mega = "." + Mega + linha.Trim();
            }
            int Tamanho = Mega.Length;
            if (Tamanho == 0)
            {
                txCampos.Text = "Texto de Pesquisa nao informado" ;
                txCampos.AppendText(Environment.NewLine);
                return;
            }
            // tudo em uma linha
            int Achei = 1; // faz ao menos 1 vez
            int P1 = 0; // p inicial 
            int P2 = 0; // p final
            while (Achei > 0)
            {
                // ler o texto várias vezes
                //txCampos.Text = txCampos.Text + "Mega: " + Mega;
                //txCampos.AppendText(Environment.NewLine);
                //
                P1 = Mega.IndexOf('`'); // p1
                // txCampos.Text = txCampos.Text + "P1:  " + P1.ToString();
                // txCampos.AppendText(Environment.NewLine);
                //if (posicao != -1)
                if (P1 != -1) { Achei = 1; } else { Achei = 0; };  // se nao achar, é zero
                string Segundo = Mega.Substring(P1 + 1);  // resto
                P2 = Segundo.IndexOf('`'); // p2 
                Tamanho = Mega.Length;
                if (P2 == 0) { P2 = Tamanho;  }; //se der merda, tenha um final
                if (P1 > 0)
                {
                    string Verbo = Segundo.Substring(0, P2);
                    txCampos.Text = txCampos.Text + Verbo;
                    txCampos.AppendText(Environment.NewLine);
                }// tem p2
                Mega = Segundo.Substring(P2 + 1);  // resto do resto              
            } // while

        } // botao - - - 

        private void txCampos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btPegaCampo_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txFormNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ListaFm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txFormulario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabFormula_Click(object sender, EventArgs e)
        {

        }

        private void btControllerCriar_Click(object sender, EventArgs e)
        {
            Fu_ClasseGrauController();
        }

        private void btCriarDao_Click(object sender, EventArgs e)
        {
            Fu_ClasseGrauDao();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    } // class
} // name
