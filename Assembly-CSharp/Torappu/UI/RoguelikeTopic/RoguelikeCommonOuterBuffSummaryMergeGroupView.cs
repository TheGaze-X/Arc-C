using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200450D RID: 17677
	[Token(Token = "0x200450D")]
	public class RoguelikeCommonOuterBuffSummaryMergeGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF81 RID: 110465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF81")]
		[Address(RVA = "0x1421880", Offset = "0x1420480", VA = "0x181421880")]
		public void Render(string topicId, RoguelikeCommonOuterBuffSummaryMergedItemModel leftModel, RoguelikeCommonOuterBuffSummaryMergedItemModel rightModel, bool hasBack)
		{
		}

		// Token: 0x0601AF82 RID: 110466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF82")]
		[Address(RVA = "0x1421A00", Offset = "0x1420600", VA = "0x181421A00")]
		public RoguelikeCommonOuterBuffSummaryMergeGroupView()
		{
		}

		// Token: 0x040229DE RID: 141790
		[Token(Token = "0x40229DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryMergeItemView _leftItem;

		// Token: 0x040229DF RID: 141791
		[Token(Token = "0x40229DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryMergeItemView _rightItem;

		// Token: 0x040229E0 RID: 141792
		[Token(Token = "0x40229E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLeft;

		// Token: 0x040229E1 RID: 141793
		[Token(Token = "0x40229E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRight;

		// Token: 0x040229E2 RID: 141794
		[Token(Token = "0x40229E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _back;

		// Token: 0x040229E3 RID: 141795
		[Token(Token = "0x40229E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229E4 RID: 141796
		[Token(Token = "0x40229E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
