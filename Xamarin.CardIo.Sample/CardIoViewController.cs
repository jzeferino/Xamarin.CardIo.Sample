using System;
using Card.IO;
using UIKit;

namespace Xamarin.CardIo.Sample
{
    internal class CardIoViewController : UIViewController, ICardIOPaymentViewControllerDelegate
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.PresentViewController(new CardIOPaymentViewController(this), true, null);
        }

        public void UserDidCancelPaymentViewController(CardIOPaymentViewController paymentViewController)
        {
            paymentViewController.DismissViewController(true, null);
        }

        public void UserDidProvideCreditCardInfo(CreditCardInfo cardInfo, CardIOPaymentViewController paymentViewController)
        {
            Console.WriteLine(cardInfo);
            paymentViewController.DismissViewController(true, null);
        }
    }
}