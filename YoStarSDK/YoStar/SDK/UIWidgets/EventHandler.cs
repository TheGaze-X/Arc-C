using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public class EventHandler : MonoBehaviour
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x5C27EA0", Offset = "0x5C26AA0", VA = "0x185C27EA0")]
		public static void Execute(string eventName)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x5C27FA0", Offset = "0x5C26BA0", VA = "0x185C27FA0")]
		public static void Execute(object obj, string eventName)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BA")]
		public static void Execute<T1>(string eventName, T1 arg1)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BB")]
		public static void Execute<T1>(object obj, string eventName, T1 arg1)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BC")]
		public static void Execute<T1, T2>(string eventName, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BD")]
		public static void Execute<T1, T2>(object obj, string eventName, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BE")]
		public static void Execute<T1, T2, T3>(string eventName, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005BF")]
		public static void Execute<T1, T2, T3>(object obj, string eventName, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x5C28260", Offset = "0x5C26E60", VA = "0x185C28260")]
		public static void Register(string eventName, Action handler)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x5C285E0", Offset = "0x5C271E0", VA = "0x185C285E0")]
		public static void Register(object obj, string eventName, Action handler)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C2")]
		public static void Register<T1>(string eventName, Action<T1> handler)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C3")]
		public static void Register<T1>(object obj, string eventName, Action<T1> handler)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C4")]
		public static void Register<T1, T2>(string eventName, Action<T1, T2> handler)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C5")]
		public static void Register<T1, T2>(object obj, string eventName, Action<T1, T2> handler)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C6")]
		public static void Register<T1, T2, T3>(string eventName, Action<T1, T2, T3> handler)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C7")]
		public static void Register<T1, T2, T3>(object obj, string eventName, Action<T1, T2, T3> handler)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x5C28CE0", Offset = "0x5C278E0", VA = "0x185C28CE0")]
		public static void Unregister(string eventName, Action handler)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x5C28B90", Offset = "0x5C27790", VA = "0x185C28B90")]
		public static void Unregister(object obj, string eventName, Action handler)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CA")]
		public static void Unregister<T1>(string eventName, Action<T1> handler)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CB")]
		public static void Unregister<T1>(object obj, string eventName, Action<T1> handler)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CC")]
		public static void Unregister<T1, T2>(string eventName, Action<T1, T2> handler)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CD")]
		public static void Unregister<T1, T2>(object obj, string eventName, Action<T1, T2> handler)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CE")]
		public static void Unregister<T1, T2, T3>(string eventName, Action<T1, T2, T3> handler)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005CF")]
		public static void Unregister<T1, T2, T3>(object obj, string eventName, Action<T1, T2, T3> handler)
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x5C28800", Offset = "0x5C27400", VA = "0x185C28800")]
		private static void Register(string eventName, Delegate handler)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x5C283F0", Offset = "0x5C26FF0", VA = "0x185C283F0")]
		private static void Register(object obj, string eventName, Delegate handler)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x5C28A80", Offset = "0x5C27680", VA = "0x185C28A80")]
		private static void Unregister(string eventName, Delegate handler)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x5C28960", Offset = "0x5C27560", VA = "0x185C28960")]
		private static void Unregister(object obj, string eventName, Delegate handler)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x5C280E0", Offset = "0x5C26CE0", VA = "0x185C280E0")]
		private static Delegate GetDelegate(string eventName)
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x5C28180", Offset = "0x5C26D80", VA = "0x185C28180")]
		private static Delegate GetDelegate(object obj, string eventName)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public EventHandler()
		{
		}

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Delegate> m_GlobalEvents;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<object, Dictionary<string, Delegate>> m_Events;
	}
}
