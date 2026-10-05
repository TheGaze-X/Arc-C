using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007163 RID: 29027
	[Token(Token = "0x2007163")]
	public class Act9D0EntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029376 RID: 168822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029376")]
		[Address(RVA = "0x2494210", Offset = "0x2492E10", VA = "0x182494210")]
		public void Render()
		{
		}

		// Token: 0x06029377 RID: 168823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029377")]
		[Address(RVA = "0x24948F0", Offset = "0x24934F0", VA = "0x1824948F0")]
		public Act9D0EntryView()
		{
		}

		// Token: 0x0403AD86 RID: 241030
		[Token(Token = "0x403AD86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textStageTimeDesc;

		// Token: 0x0403AD87 RID: 241031
		[Token(Token = "0x403AD87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRewardTimeDesc;

		// Token: 0x0403AD88 RID: 241032
		[Token(Token = "0x403AD88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbstractStageTime _stage;

		// Token: 0x0403AD89 RID: 241033
		[Token(Token = "0x403AD89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0403AD8A RID: 241034
		[Token(Token = "0x403AD8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0403AD8B RID: 241035
		[Token(Token = "0x403AD8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AbstractRemainTime _remainTime;

		// Token: 0x0403AD8C RID: 241036
		[Token(Token = "0x403AD8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AD8D RID: 241037
		[Token(Token = "0x403AD8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
