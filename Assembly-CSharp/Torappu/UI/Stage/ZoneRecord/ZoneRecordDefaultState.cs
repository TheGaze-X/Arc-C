using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord
{
	// Token: 0x02006A03 RID: 27139
	[Token(Token = "0x2006A03")]
	public class ZoneRecordDefaultState : State
	{
		// Token: 0x06026CD6 RID: 158934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026CD6")]
		[Address(RVA = "0x21DD2C0", Offset = "0x21DBEC0", VA = "0x1821DD2C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026CD7 RID: 158935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD7")]
		[Address(RVA = "0x21DD320", Offset = "0x21DBF20", VA = "0x1821DD320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026CD8 RID: 158936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD8")]
		[Address(RVA = "0x21DD590", Offset = "0x21DC190", VA = "0x1821DD590", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06026CD9 RID: 158937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD9")]
		[Address(RVA = "0x21DDB80", Offset = "0x21DC780", VA = "0x1821DDB80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026CDA RID: 158938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDA")]
		[Address(RVA = "0x21DD880", Offset = "0x21DC480", VA = "0x1821DD880")]
		private void _InitDecodeView(string zoneId)
		{
		}

		// Token: 0x06026CDB RID: 158939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDB")]
		[Address(RVA = "0x21DD680", Offset = "0x21DC280", VA = "0x1821DD680")]
		private void _CloseZoneRecord()
		{
		}

		// Token: 0x06026CDC RID: 158940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDC")]
		[Address(RVA = "0x21DDD00", Offset = "0x21DC900", VA = "0x1821DDD00")]
		public ZoneRecordDefaultState()
		{
		}

		// Token: 0x06026CDD RID: 158941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026CDE RID: 158942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04036D19 RID: 224537
		[Token(Token = "0x4036D19")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04036D1A RID: 224538
		[Token(Token = "0x4036D1A")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform m_controllerContainer;

		// Token: 0x04036D1B RID: 224539
		[Token(Token = "0x4036D1B")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedZoneId;

		// Token: 0x04036D1C RID: 224540
		[Token(Token = "0x4036D1C")]
		[FieldOffset(Offset = "0x68")]
		private ZoneRecordController m_controller;

		// Token: 0x04036D1D RID: 224541
		[Token(Token = "0x4036D1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036D1E RID: 224542
		[Token(Token = "0x4036D1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036D1F RID: 224543
		[Token(Token = "0x4036D1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036D20 RID: 224544
		[Token(Token = "0x4036D20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036D21 RID: 224545
		[Token(Token = "0x4036D21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitDecodeView;

		// Token: 0x04036D22 RID: 224546
		[Token(Token = "0x4036D22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseZoneRecord;

		// Token: 0x04036D23 RID: 224547
		[Token(Token = "0x4036D23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
