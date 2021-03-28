namespace ExercicioComposicao.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
