﻿using SimpleMassiveRealtimeRankingServer.Server.PacketHandlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpleMassiveRealtimeRankingServer.Server;
using CSharpUtils.Extensions;
using SimpleMassiveRealtimeRankingServerTests.Server.PacketHandlers.Helpers;

namespace SimpleMassiveRealtimeRankingServerTests
{
	[TestClass]
	public class PingHandlerTest
	{
		[TestMethod]
		public void HandlePacketTest()
		{
			var TestPacketHelperInstance = new TestPacketHelper(
				Packet.PacketType.Ping,
				new PingHandler()
			);

			TestPacketHelperInstance.Handle((Stream) =>
			{
			});

			Assert.AreEqual(
				"Packet(Type=Ping, Data=)",
				TestPacketHelperInstance.PacketToSend.ToString()
			);
		}
	}
}
