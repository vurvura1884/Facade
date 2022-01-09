using System;

namespace Facade
{
    class Program
    {
        class Purchase
        {
            public void FindEquipment()
            {
                Console.WriteLine("Найдено нужное оборудование");
            }
        }
        class Delivery
        {
            public void DeliverEquipment()
            {
                Console.WriteLine("Оборудование доставлено");
            }
        }
        class ContractCreating
        {
            public void Signaturing()
            {
                Console.WriteLine("Договор создан");
            }
        }
        class Payment
        {
            public void Pay()
            {
                Console.WriteLine("Закупка оплачена");
            }
        }
        class BuyingEquipmentFacade
        {
            Purchase purechace;
            Delivery delivery;
            ContractCreating contractCreating;
            Payment payment;
            public BuyingEquipmentFacade(Purchase pur, Delivery de, ContractCreating cc, Payment pay)
            {
                this.purechace = pur;
                this.delivery = de;
                this.contractCreating = cc;
                this.payment = pay;
            }

            public void Do()
            {
                purechace.FindEquipment();
                delivery.DeliverEquipment();
                contractCreating.Signaturing();
                payment.Pay();
            }
        }

        class Lab
        {
            public void OrderEquipment(BuyingEquipmentFacade facade)
            {
                facade.Do();
            }
        }


        static void Main(string[] args)
        {
            Purchase purechace = new Purchase();
            Delivery delivery = new Delivery();
            ContractCreating contractCreating = new ContractCreating();
            Payment payment = new Payment();
            BuyingEquipmentFacade facade1 = new BuyingEquipmentFacade(purechace, delivery, contractCreating, payment);
            Lab lab = new Lab();
            lab.OrderEquipment(facade1);
        }
    }
}