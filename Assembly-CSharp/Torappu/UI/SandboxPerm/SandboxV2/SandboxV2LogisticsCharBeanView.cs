using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433B RID: 17211
	[Token(Token = "0x200433B")]
	public class SandboxV2LogisticsCharBeanView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A706 RID: 108294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A706")]
		[Address(RVA = "0x1386380", Offset = "0x1384F80", VA = "0x181386380")]
		public void Render(int totalCount, int currentCount)
		{
		}

		// Token: 0x0601A707 RID: 108295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A707")]
		[Address(RVA = "0x13865B0", Offset = "0x13851B0", VA = "0x1813865B0")]
		public SandboxV2LogisticsCharBeanView()
		{
		}

		// Token: 0x04021989 RID: 137609
		[Token(Token = "0x4021989")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2LogisticsAbstractBeanItem _panelBeanPrefab;

		// Token: 0x0402198A RID: 137610
		[Token(Token = "0x402198A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402198B RID: 137611
		[Token(Token = "0x402198B")]
		[FieldOffset(Offset = "0x24")]
		private int m_cachedTotalBeanCount;

		// Token: 0x0402198C RID: 137612
		[Token(Token = "0x402198C")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedCurrentBeanCount;

		// Token: 0x0402198D RID: 137613
		[Token(Token = "0x402198D")]
		[FieldOffset(Offset = "0x30")]
		private List<SandboxV2LogisticsAbstractBeanItem> m_itemList;

		// Token: 0x0402198E RID: 137614
		[Token(Token = "0x402198E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402198F RID: 137615
		[Token(Token = "0x402198F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
