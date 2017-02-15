namespace PrimS.Telnet.NetStandard.CiTests
{
  using System;
  using System.Linq;
  using FluentAssertions;
  using System.Threading.Tasks;
  using System.Text.RegularExpressions;
  using System.Diagnostics.CodeAnalysis;
  using Telnet.CiTests;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class WithClient
  {
    private const int TimeoutMs = 100;

    [TestMethod]
    public void ShouldConnect()
    {
      using (TelnetServer server = new TelnetServer())
      {
        using (Client client = new Client(server.IPAddress.ToString(), server.Port, new System.Threading.CancellationToken()))
        {
          client.IsConnected.Should().Be(true);
        }
      }
    }
  }
}