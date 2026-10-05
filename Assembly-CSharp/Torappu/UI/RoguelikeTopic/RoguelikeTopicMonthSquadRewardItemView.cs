using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044DF RID: 17631
	[Token(Token = "0x20044DF")]
	public class RoguelikeTopicMonthSquadRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AEC3 RID: 110275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC3")]
		[Address(RVA = "0x1411E40", Offset = "0x1410A40", VA = "0x181411E40")]
		public void Render(ItemBundle rewardItemData, bool hasReceivedAward, bool enableDropRoute = true)
		{
		}

		// Token: 0x0601AEC4 RID: 110276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC4")]
		[Address(RVA = "0x1412240", Offset = "0x1410E40", VA = "0x181412240")]
		public RoguelikeTopicMonthSquadRewardItemView()
		{
		}

		// Token: 0x04022856 RID: 141398
		[Token(Token = "0x4022856")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04022857 RID: 141399
		[Token(Token = "0x4022857")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_itemCard;

		// Token: 0x04022858 RID: 141400
		[Token(Token = "0x4022858")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022859 RID: 141401
		[Token(Token = "0x4022859")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
