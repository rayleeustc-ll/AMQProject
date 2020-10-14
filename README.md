**Start TestAmqpBroker**

1. cd TestAmqpBroker folder

2. run 

   ```powershell
   .\TestAmqpBroker.exe amqp://localhost:5672 /creds:guest:guest /queues:amqp
   ```

**Start Receiver**

1. cd Receiver folder

2. Ctrl+F5 or run 

   ```csharp
   dotnet run
   ```

**Start Sender**

1. cd Sender folder

2. Ctrl+F5 or run 

   ```csharp
   dotnet run
   ```