using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E61 RID: 20065
	[Token(Token = "0x2004E61")]
	public class FireworkPuzzleMapView : DataBinder<FireworkPuzzleMapProperty>
	{
		// Token: 0x0601DF16 RID: 122646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF16")]
		[Address(RVA = "0x17AAD70", Offset = "0x17A9970", VA = "0x1817AAD70", Slot = "7")]
		public override void OnValueChanged(FireworkPuzzleMapProperty property)
		{
		}

		// Token: 0x0601DF17 RID: 122647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF17")]
		[Address(RVA = "0x17AB080", Offset = "0x17A9C80", VA = "0x1817AB080")]
		public FireworkPuzzleMapView()
		{
		}

		// Token: 0x04027C0D RID: 162829
		[Token(Token = "0x4027C0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FireworkPuzzleMapStageItem[] _stageItems;

		// Token: 0x04027C0E RID: 162830
		[Token(Token = "0x4027C0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _puzzleCompletedText;

		// Token: 0x04027C0F RID: 162831
		[Token(Token = "0x4027C0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _puzzleTotalText;

		// Token: 0x04027C10 RID: 162832
		[Token(Token = "0x4027C10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _mapAnimToggle;

		// Token: 0x04027C11 RID: 162833
		[Token(Token = "0x4027C11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04027C12 RID: 162834
		[Token(Token = "0x4027C12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _puzzleListDesc;

		// Token: 0x04027C13 RID: 162835
		[Token(Token = "0x4027C13")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _puzzleDailyRewardNum;

		// Token: 0x04027C14 RID: 162836
		[Token(Token = "0x4027C14")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedFocusSeqNum;

		// Token: 0x04027C15 RID: 162837
		[Token(Token = "0x4027C15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027C16 RID: 162838
		[Token(Token = "0x4027C16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
