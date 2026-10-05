using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002043 RID: 8259
	[Token(Token = "0x2002043")]
	public class CollectCertainObjsInScene : BaseSceneEffect
	{
		// Token: 0x0600CB86 RID: 52102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB86")]
		[Address(RVA = "0x34BEA30", Offset = "0x34BD630", VA = "0x1834BEA30")]
		public List<GameObject> GetObjs(string keyword)
		{
			return null;
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB87")]
		[Address(RVA = "0x34BED10", Offset = "0x34BD910", VA = "0x1834BED10", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB88")]
		[Address(RVA = "0x34BECA0", Offset = "0x34BD8A0", VA = "0x1834BECA0", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB89")]
		[Address(RVA = "0x34BEAF0", Offset = "0x34BD6F0", VA = "0x1834BEAF0", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB8A")]
		[Address(RVA = "0x34BEE00", Offset = "0x34BDA00", VA = "0x1834BEE00")]
		public CollectCertainObjsInScene()
		{
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB8B")]
		[Address(RVA = "0x34BE730", Offset = "0x34BD330", VA = "0x1834BE730")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CB8C RID: 52108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB8C")]
		[Address(RVA = "0x34BE6D0", Offset = "0x34BD2D0", VA = "0x1834BE6D0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CB8D RID: 52109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB8D")]
		[Address(RVA = "0x34BE5F0", Offset = "0x34BD1F0", VA = "0x1834BE5F0")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0400D5C3 RID: 54723
		[Token(Token = "0x400D5C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _keyword;

		// Token: 0x0400D5C4 RID: 54724
		[Token(Token = "0x400D5C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _objsList;

		// Token: 0x0400D5C5 RID: 54725
		[Token(Token = "0x400D5C5")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, List<GameObject>> m_objMap;

		// Token: 0x0400D5C6 RID: 54726
		[Token(Token = "0x400D5C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetObjs;

		// Token: 0x0400D5C7 RID: 54727
		[Token(Token = "0x400D5C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D5C8 RID: 54728
		[Token(Token = "0x400D5C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D5C9 RID: 54729
		[Token(Token = "0x400D5C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D5CA RID: 54730
		[Token(Token = "0x400D5CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
