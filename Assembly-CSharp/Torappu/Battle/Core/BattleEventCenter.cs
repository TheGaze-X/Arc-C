using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Core
{
	// Token: 0x02002A30 RID: 10800
	[Token(Token = "0x2002A30")]
	public class BattleEventCenter : SingletonWithMonoHost<BattleEventCenter, BattleController>, IDisposable
	{
		// Token: 0x06011EAB RID: 73387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EAB")]
		[Address(RVA = "0x9C14A0", Offset = "0x9C00A0", VA = "0x1809C14A0")]
		private BattleEventCenter()
		{
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06011EAC RID: 73388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700276B")]
		public static EventPool<BattleEvent> oriEventPool
		{
			[Token(Token = "0x6011EAC")]
			[Address(RVA = "0x9C15B0", Offset = "0x9C01B0", VA = "0x1809C15B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011EAD RID: 73389 RVA: 0x0006D878 File Offset: 0x0006BA78
		[Token(Token = "0x6011EAD")]
		[Address(RVA = "0x9C0880", Offset = "0x9BF480", VA = "0x1809C0880")]
		public static bool OnCommonEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
			return default(bool);
		}

		// Token: 0x06011EAE RID: 73390 RVA: 0x0006D890 File Offset: 0x0006BA90
		[Token(Token = "0x6011EAE")]
		[Address(RVA = "0x9C09B0", Offset = "0x9BF5B0", VA = "0x1809C09B0")]
		public static bool OnPluginEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
			return default(bool);
		}

		// Token: 0x06011EAF RID: 73391 RVA: 0x0006D8A8 File Offset: 0x0006BAA8
		[Token(Token = "0x6011EAF")]
		[Address(RVA = "0x9C00B0", Offset = "0x9BECB0", VA = "0x1809C00B0")]
		public static bool EmitCommonEvent(int eventNum)
		{
			return default(bool);
		}

		// Token: 0x06011EB0 RID: 73392 RVA: 0x0006D8C0 File Offset: 0x0006BAC0
		[Token(Token = "0x6011EB0")]
		[Address(RVA = "0x9BFF20", Offset = "0x9BEB20", VA = "0x1809BFF20")]
		public static bool EmitCommonEvent(int eventNum, ValueBundle bundle)
		{
			return default(bool);
		}

		// Token: 0x06011EB1 RID: 73393 RVA: 0x0006D8D8 File Offset: 0x0006BAD8
		[Token(Token = "0x6011EB1")]
		[Address(RVA = "0x9C04A0", Offset = "0x9BF0A0", VA = "0x1809C04A0")]
		public static bool EmitPluginEvent(int eventNum)
		{
			return default(bool);
		}

		// Token: 0x06011EB2 RID: 73394 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		[Token(Token = "0x6011EB2")]
		[Address(RVA = "0x9C0700", Offset = "0x9BF300", VA = "0x1809C0700")]
		public static bool EmitPluginEvent(int eventNum, object arg)
		{
			return default(bool);
		}

		// Token: 0x06011EB3 RID: 73395 RVA: 0x0006D908 File Offset: 0x0006BB08
		[Token(Token = "0x6011EB3")]
		[Address(RVA = "0x9C02C0", Offset = "0x9BEEC0", VA = "0x1809C02C0")]
		public static bool EmitPluginEvent(int eventNum, ValueBundle bundle)
		{
			return default(bool);
		}

		// Token: 0x06011EB4 RID: 73396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EB4")]
		[Address(RVA = "0x9C0B30", Offset = "0x9BF730", VA = "0x1809C0B30")]
		public static void RemoveCommonEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EB5 RID: 73397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EB5")]
		[Address(RVA = "0x9C0C50", Offset = "0x9BF850", VA = "0x1809C0C50")]
		public static void RemovePluginEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EB6 RID: 73398 RVA: 0x0006D920 File Offset: 0x0006BB20
		[Token(Token = "0x6011EB6")]
		[Address(RVA = "0x9C10F0", Offset = "0x9BFCF0", VA = "0x1809C10F0")]
		private static int _GetRealPluginEventNum(int eventNum)
		{
			return 0;
		}

		// Token: 0x06011EB7 RID: 73399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EB7")]
		[Address(RVA = "0x9C1150", Offset = "0x9BFD50", VA = "0x1809C1150")]
		private void _OnCommonEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EB8 RID: 73400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EB8")]
		[Address(RVA = "0x9C1200", Offset = "0x9BFE00", VA = "0x1809C1200")]
		private void _OnPluginEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EB9 RID: 73401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EB9")]
		[Address(RVA = "0x9C0DC0", Offset = "0x9BF9C0", VA = "0x1809C0DC0")]
		private void _EmitCommonEvent(int eventNum, ValueBundle bundle)
		{
		}

		// Token: 0x06011EBA RID: 73402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EBA")]
		[Address(RVA = "0x9C0EB0", Offset = "0x9BFAB0", VA = "0x1809C0EB0")]
		private void _EmitPluginEvent(int eventNum, ValueBundle bundle)
		{
		}

		// Token: 0x06011EBB RID: 73403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EBB")]
		[Address(RVA = "0x9C0FF0", Offset = "0x9BFBF0", VA = "0x1809C0FF0")]
		private void _EmitPluginEvent(int eventNum, [Optional] object obj)
		{
		}

		// Token: 0x06011EBC RID: 73404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EBC")]
		[Address(RVA = "0x9C12F0", Offset = "0x9BFEF0", VA = "0x1809C12F0")]
		private void _RemoveCommonEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EBD RID: 73405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EBD")]
		[Address(RVA = "0x9C13A0", Offset = "0x9BFFA0", VA = "0x1809C13A0")]
		private void _RemovePluginEvent(int eventNum, EventPool.EventCallbackDelegate battleDelegate)
		{
		}

		// Token: 0x06011EBE RID: 73406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EBE")]
		[Address(RVA = "0x9BFEA0", Offset = "0x9BEAA0", VA = "0x1809BFEA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0401432D RID: 82733
		[Token(Token = "0x401432D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EventPool<BattleEvent> m_oriBattleEventPool;

		// Token: 0x0401432E RID: 82734
		[Token(Token = "0x401432E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EventPool<int> m_eventPool;

		// Token: 0x0401432F RID: 82735
		[Token(Token = "0x401432F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04014330 RID: 82736
		[Token(Token = "0x4014330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_oriEventPool;

		// Token: 0x04014331 RID: 82737
		[Token(Token = "0x4014331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCommonEvent;

		// Token: 0x04014332 RID: 82738
		[Token(Token = "0x4014332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPluginEvent;

		// Token: 0x04014333 RID: 82739
		[Token(Token = "0x4014333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EmitCommonEvent;

		// Token: 0x04014334 RID: 82740
		[Token(Token = "0x4014334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_EmitCommonEvent;

		// Token: 0x04014335 RID: 82741
		[Token(Token = "0x4014335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EmitPluginEvent;

		// Token: 0x04014336 RID: 82742
		[Token(Token = "0x4014336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_EmitPluginEvent;

		// Token: 0x04014337 RID: 82743
		[Token(Token = "0x4014337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix2_EmitPluginEvent;

		// Token: 0x04014338 RID: 82744
		[Token(Token = "0x4014338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RemoveCommonEvent;

		// Token: 0x04014339 RID: 82745
		[Token(Token = "0x4014339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RemovePluginEvent;

		// Token: 0x0401433A RID: 82746
		[Token(Token = "0x401433A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetRealPluginEventNum;

		// Token: 0x0401433B RID: 82747
		[Token(Token = "0x401433B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCommonEvent;

		// Token: 0x0401433C RID: 82748
		[Token(Token = "0x401433C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnPluginEvent;

		// Token: 0x0401433D RID: 82749
		[Token(Token = "0x401433D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EmitCommonEvent;

		// Token: 0x0401433E RID: 82750
		[Token(Token = "0x401433E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EmitPluginEvent;

		// Token: 0x0401433F RID: 82751
		[Token(Token = "0x401433F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1__EmitPluginEvent;

		// Token: 0x04014340 RID: 82752
		[Token(Token = "0x4014340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RemoveCommonEvent;

		// Token: 0x04014341 RID: 82753
		[Token(Token = "0x4014341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RemovePluginEvent;

		// Token: 0x04014342 RID: 82754
		[Token(Token = "0x4014342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
