using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A8A RID: 19082
	[Token(Token = "0x2004A8A")]
	public class HotUpdatePreMainTicker : IHotfixable
	{
		// Token: 0x0601CAD5 RID: 117461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD5")]
		[Address(RVA = "0x1624810", Offset = "0x1623410", VA = "0x181624810")]
		public HotUpdatePreMainTicker(Action onChangePic)
		{
		}

		// Token: 0x0601CAD6 RID: 117462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD6")]
		[Address(RVA = "0x1624770", Offset = "0x1623370", VA = "0x181624770")]
		public void _OnTickWork(float deltaTime)
		{
		}

		// Token: 0x0601CAD7 RID: 117463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD7")]
		[Address(RVA = "0x1624690", Offset = "0x1623290", VA = "0x181624690")]
		public void StartTick()
		{
		}

		// Token: 0x0601CAD8 RID: 117464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD8")]
		[Address(RVA = "0x1624700", Offset = "0x1623300", VA = "0x181624700")]
		public void StopTick()
		{
		}

		// Token: 0x0601CAD9 RID: 117465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD9")]
		[Address(RVA = "0x1624610", Offset = "0x1623210", VA = "0x181624610")]
		public void OnClear()
		{
		}

		// Token: 0x04025A39 RID: 154169
		[Token(Token = "0x4025A39")]
		[FieldOffset(Offset = "0x10")]
		private TickFunction m_tickPreMainFunction;

		// Token: 0x04025A3A RID: 154170
		[Token(Token = "0x4025A3A")]
		[FieldOffset(Offset = "0x18")]
		private float m_preMainLastTimeStamp;

		// Token: 0x04025A3B RID: 154171
		[Token(Token = "0x4025A3B")]
		[FieldOffset(Offset = "0x1C")]
		private float m_preMainTimeStamp;

		// Token: 0x04025A3C RID: 154172
		[Token(Token = "0x4025A3C")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onChangePic;

		// Token: 0x04025A3D RID: 154173
		[Token(Token = "0x4025A3D")]
		[FieldOffset(Offset = "0x28")]
		private float delta;

		// Token: 0x04025A3E RID: 154174
		[Token(Token = "0x4025A3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04025A3F RID: 154175
		[Token(Token = "0x4025A3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnTickWork;

		// Token: 0x04025A40 RID: 154176
		[Token(Token = "0x4025A40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartTick;

		// Token: 0x04025A41 RID: 154177
		[Token(Token = "0x4025A41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopTick;

		// Token: 0x04025A42 RID: 154178
		[Token(Token = "0x4025A42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClear;
	}
}
