# SlideExplorerBTControler
publish



File: BTService.cs  Project: JayDalton/SlideExplorerBTControler


private void BluetoothConnect(BluetoothAddress addr)
 {
     BluetoothClient btClient = new BluetoothClient();
       try
       {
     btClient.Connect(addr, OurServiceClassId);
     var peer = btClient.GetStream();
     SetConnection(peer, true, btClient.RemoteEndPoint);
     ThreadPool.QueueUserWorkItem(ReadMessagesToEnd_Runner, peer);
       }
       catch (SocketException ex)
       {
     // Try to give a explanation reason by checking what error-code.
     // http://32feet.codeplex.com/wikipage?title=Errors
     // Note the error codes used on MSFT+WM are not the same as on
     // MSFT+Win32 so don't expect much there, we try to use the
     // same error codes on the other platforms where possible.
     // e.g. Widcomm doesn't match well, Bluetopia does.
     // http://32feet.codeplex.com/wikipage?title=Feature support table
     string reason;
     switch (ex.ErrorCode)
     {
       case 10048: // SocketError.AddressAlreadyInUse
     // RFCOMM only allow _one_ connection to a remote service from each device.
     reason = "There is an existing connection to the remote Chat2 Service";
     break;
       case 10049: // SocketError.AddressNotAvailable
     reason = "Chat2 Service not running on remote device";
     break;
       case 10064: // SocketError.HostDown
     reason = "Chat2 Service not using RFCOMM (huh!!!)";
     break;
       case 10013: // SocketError.AccessDenied:
     reason = "Authentication required";
     break;
       case 10060: // SocketError.TimedOut:
     reason = "Timed-out";
     break;
       default:
     reason = null;
     break;
     }
     reason += " (" + ex.ErrorCode.ToString() + ") -- ";
     //
     var msg = "Bluetooth connection failed: " + ex;
     msg = reason + msg;
     AddMessage(MessageSource.Error, msg);
     System.Windows.MessageBox.Show(msg);
       }
       catch (Exception ex)
       {
     var msg = "Bluetooth connection failed: " + ex;
     AddMessage(MessageSource.Error, msg);
     System.Windows.MessageBox.Show(msg);
       }
 }
