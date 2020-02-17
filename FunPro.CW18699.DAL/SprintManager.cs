using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
using FunPro.CW1._8699.DAL;

namespace FunPro.CW18699.DAL
{
    ///////// All Ticket need to be replaced with Sprint by tomorrow. see you there!
    /*
    class SprintManager
    {
        public void Create(Ticket c)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $"INSERT INTO Ticket (Ti_summary) VALUES ('{c.Ti_summary}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public List<Ticket> GetAll()
        {
            var connection = new SqlCeConnection("");
            var result = new List<Ticket>();
            try
            {
                var sql = "SELECT Ti_id, Ti_summary FROM Ticket";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Ticket
                    {
                        Ti_id = Convert.ToInt32(reader.GetValue(0)),
                        Ti_summary = Convert.ToString(reader.GetValue(1))
                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }



        public void Update(Ticket c)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $@"UPDATE Ticket SET Ti_summary = '{c.Ti_summary}' WHERE Ti_id={c.Ti_id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }


        public void Delete(Ticket c)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $"DELETE FROM Ticket WHERE Ti_id={c.Ti_id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }



        public Ticket GetById(int id)
        {
            var connection = new SqlCeConnection("");
            var result = new List<Ticket>();
            try
            {
                var sql = $"SELECT Ti_id, Ti_summary FROM Ticket WHERE Ti_id={id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new Ticket
                    {
                        Ti_id = Convert.ToInt32(reader.GetValue(0)),
                        Ti_summary = Convert.ToString(reader.GetValue(1))
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return null;
        }


    }
    */
}
