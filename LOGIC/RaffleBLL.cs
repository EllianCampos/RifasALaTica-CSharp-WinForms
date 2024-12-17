using DATA;
using ENTITIES;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LOGIC
{
    public class RaffleBLL
    {
        private readonly RaffleDAL _raffleDAL;

        public RaffleBLL()
        {
            _raffleDAL = new RaffleDAL();
        }

        public Raffle? GetById(int id) => _raffleDAL.GetById(id);

        public (int, List<Raffle>) GetPaginated(int limit, int offset) => _raffleDAL.GetPaginated(limit, offset);

        public Result Save(Raffle raffle)
        {
            var errors = new Dictionary<string, string>();

            if (raffle.Name == null)
                errors.Add("Name", "El nombre del sorteo es requerido");

            if (raffle.Name == null)
                errors.Add("Date", "La fecha de sorteo es requerida");

            if (raffle.Price == 0)
                errors.Add("Price", "Ingresa el valor del número");

            if (errors.Count > 0)
                return new Result { Success = false, Message = "Los campos no cumplem con las validaciones", Errors = errors };

            try
            {
                var result = 
                        raffle.Id == 0 
                            ? _raffleDAL.Insert(raffle) 
                            : _raffleDAL.Update(raffle);

                if (!result)
                    throw new Exception("La operación no se completo");

                return new Result { Success = true, Message = "Rifa guardada exitosamente" };

            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = "Algo salio mal: " + ex.Message };
            }
        }

        public Result Delete(int id)
        {
            try
            {
                var result = _raffleDAL.Delete(id);

                if (!result)
                    throw new Exception("Error al eliminar el sorteo");

                return new Result { Success = true, Message = "Rifa Eliminada" };
            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = "Algo salio mal: " + ex.Message };
            }
        }
    }
}
