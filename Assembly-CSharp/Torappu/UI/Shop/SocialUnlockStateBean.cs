using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B79 RID: 23417
	[Token(Token = "0x2005B79")]
	public class SocialUnlockStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021FE0 RID: 139232 RVA: 0x000BC238 File Offset: 0x000BA438
		[Token(Token = "0x6021FE0")]
		[Address(RVA = "0x1C83480", Offset = "0x1C82080", VA = "0x181C83480")]
		private bool _CheckCharUnlock(string charId)
		{
			return default(bool);
		}

		// Token: 0x06021FE1 RID: 139233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FE1")]
		[Address(RVA = "0x1C82E40", Offset = "0x1C81A40", VA = "0x181C82E40")]
		public void InitGroupId(string groupId)
		{
		}

		// Token: 0x06021FE2 RID: 139234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FE2")]
		[Address(RVA = "0x1C835E0", Offset = "0x1C821E0", VA = "0x181C835E0")]
		public SocialUnlockStateBean()
		{
		}

		// Token: 0x0402E981 RID: 190849
		[Token(Token = "0x402E981")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float percentMin;

		// Token: 0x0402E982 RID: 190850
		[Token(Token = "0x402E982")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Dictionary<string, int> charUnlockState;

		// Token: 0x0402E983 RID: 190851
		[Token(Token = "0x402E983")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string currentGroupId;

		// Token: 0x0402E984 RID: 190852
		[Token(Token = "0x402E984")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Dictionary<int, CreditGroupObjViewModel> groupList;

		// Token: 0x0402E985 RID: 190853
		[Token(Token = "0x402E985")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public int maxLength;

		// Token: 0x0402E986 RID: 190854
		[Token(Token = "0x402E986")]
		[FieldOffset(Offset = "0x34")]
		[NonSerialized]
		public int minLength;

		// Token: 0x0402E987 RID: 190855
		[Token(Token = "0x402E987")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public float maxPercent;

		// Token: 0x0402E988 RID: 190856
		[Token(Token = "0x402E988")]
		[FieldOffset(Offset = "0x3C")]
		[NonSerialized]
		public int creditUsed;

		// Token: 0x0402E989 RID: 190857
		[Token(Token = "0x402E989")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public string creditGroup;

		// Token: 0x0402E98A RID: 190858
		[Token(Token = "0x402E98A")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, int> m_charUnlockCache;

		// Token: 0x0402E98B RID: 190859
		[Token(Token = "0x402E98B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckCharUnlock;

		// Token: 0x0402E98C RID: 190860
		[Token(Token = "0x402E98C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitGroupId;

		// Token: 0x0402E98D RID: 190861
		[Token(Token = "0x402E98D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
