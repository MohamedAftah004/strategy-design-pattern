Strategy Design Pattern (C#)

This project demonstrates the Strategy Design Pattern implemented in C#.
It simulates an e-commerce pricing and payment system where different algorithms are used interchangeably to calculate prices and process payments based on user membership and payment method.

🧠 Concept
The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
It lets the algorithm vary independently from the clients that use it — promoting flexibility and open/closed design.

⚙️ Implementation Overview

Context (ECommercePlatform):
Manages product pricing and checkout operations. It uses different strategy objects for price calculation and payment processing.

Price Strategy (IPriceStrategy):
Defines the interface for pricing logic.
Implementations include:

RegularMemberStrategy

GoldMemberStrategy

PremiumMemberStrategy

Payment Strategy (IPaymentStrategy):
Defines the interface for payment processing logic.
Implementations include:

PayPalPayment

VisaPayment

BankTransferPayment

Client (Main Program):
Chooses and applies pricing and payment strategies dynamically at runtime.

🚀 How to Run
Clone the repository:

git clone https://github.com/MohamedAftah004/strategy-design-pattern.git


Build and run the C# project to see how different strategies produce different results for pricing and payment logic.
