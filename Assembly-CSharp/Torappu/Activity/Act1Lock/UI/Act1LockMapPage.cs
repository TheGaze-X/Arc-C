using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007875 RID: 30837
	[Token(Token = "0x2007875")]
	public class Act1LockMapPage : StateEnginePage, IHotfixable
	{
		// Token: 0x0602B387 RID: 177031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B387")]
		[Address(RVA = "0x2709100", Offset = "0x2707D00", VA = "0x182709100", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602B388 RID: 177032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B388")]
		[Address(RVA = "0x2709070", Offset = "0x2707C70", VA = "0x182709070", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602B389 RID: 177033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B389")]
		[Address(RVA = "0x2708FC0", Offset = "0x2707BC0", VA = "0x182708FC0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602B38A RID: 177034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B38A")]
		[Address(RVA = "0x2709260", Offset = "0x2707E60", VA = "0x182709260")]
		private IEnumerator _LoadFromCache(string stageId)
		{
			return null;
		}

		// Token: 0x0602B38B RID: 177035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B38B")]
		[Address(RVA = "0x27093C0", Offset = "0x2707FC0", VA = "0x1827093C0")]
		private void _TriggerInterlockAVG()
		{
		}

		// Token: 0x0602B38C RID: 177036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B38C")]
		[Address(RVA = "0x2709330", Offset = "0x2707F30", VA = "0x182709330")]
		private void _OnAvgFinished(Story story)
		{
		}

		// Token: 0x0602B38D RID: 177037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B38D")]
		[Address(RVA = "0x2708E10", Offset = "0x2707A10", VA = "0x182708E10")]
		public void AVGOnly_BackToMapView()
		{
		}

		// Token: 0x0602B38E RID: 177038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B38E")]
		[Address(RVA = "0x2709580", Offset = "0x2708180", VA = "0x182709580")]
		public Act1LockMapPage()
		{
		}

		// Token: 0x0602B390 RID: 177040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B390")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0602B391 RID: 177041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B391")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602B392 RID: 177042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B392")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0403E7BD RID: 255933
		[Token(Token = "0x403E7BD")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Act1LockAVGAdapter _avgAdapter;

		// Token: 0x0403E7BE RID: 255934
		[Token(Token = "0x403E7BE")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Act1LockZoneMapStateBean m_mapStateBean;

		// Token: 0x0403E7BF RID: 255935
		[Token(Token = "0x403E7BF")]
		[FieldOffset(Offset = "0x100")]
		private DataBundle m_dataBundle4InitStateEngine;

		// Token: 0x0403E7C0 RID: 255936
		[Token(Token = "0x403E7C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403E7C1 RID: 255937
		[Token(Token = "0x403E7C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403E7C2 RID: 255938
		[Token(Token = "0x403E7C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0403E7C3 RID: 255939
		[Token(Token = "0x403E7C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadFromCache;

		// Token: 0x0403E7C4 RID: 255940
		[Token(Token = "0x403E7C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerInterlockAVG;

		// Token: 0x0403E7C5 RID: 255941
		[Token(Token = "0x403E7C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAvgFinished;

		// Token: 0x0403E7C6 RID: 255942
		[Token(Token = "0x403E7C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AVGOnly_BackToMapView;

		// Token: 0x0403E7C7 RID: 255943
		[Token(Token = "0x403E7C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007876 RID: 30838
		[Token(Token = "0x2007876")]
		public class Params
		{
			// Token: 0x0602B393 RID: 177043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B393")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403E7C8 RID: 255944
			[Token(Token = "0x403E7C8")]
			[FieldOffset(Offset = "0x10")]
			public string selectedStageId;
		}
	}
}
