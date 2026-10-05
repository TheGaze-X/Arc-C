using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C8 RID: 27080
	[Token(Token = "0x20069C8")]
	public class ZoneRecordContentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026BF3 RID: 158707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BF3")]
		[Address(RVA = "0x21DC9F0", Offset = "0x21DB5F0", VA = "0x1821DC9F0")]
		public void Render(ZoneRecordViewModel viewModel, bool selected)
		{
		}

		// Token: 0x06026BF4 RID: 158708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BF4")]
		[Address(RVA = "0x21DCC30", Offset = "0x21DB830", VA = "0x1821DCC30")]
		private void _InitIfNot(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026BF5 RID: 158709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BF5")]
		[Address(RVA = "0x21DCCD0", Offset = "0x21DB8D0", VA = "0x1821DCCD0")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x06026BF6 RID: 158710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BF6")]
		[Address(RVA = "0x21DCD50", Offset = "0x21DB950", VA = "0x1821DCD50")]
		public ZoneRecordContentItemView()
		{
		}

		// Token: 0x04036B7A RID: 224122
		[Token(Token = "0x4036B7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04036B7B RID: 224123
		[Token(Token = "0x4036B7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageId;

		// Token: 0x04036B7C RID: 224124
		[Token(Token = "0x4036B7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04036B7D RID: 224125
		[Token(Token = "0x4036B7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _grayColor;

		// Token: 0x04036B7E RID: 224126
		[Token(Token = "0x4036B7E")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onEvent;

		// Token: 0x04036B7F RID: 224127
		[Token(Token = "0x4036B7F")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedRecordId;

		// Token: 0x04036B80 RID: 224128
		[Token(Token = "0x4036B80")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04036B81 RID: 224129
		[Token(Token = "0x4036B81")]
		[FieldOffset(Offset = "0x54")]
		private Color NORMAL_COLOR;

		// Token: 0x04036B82 RID: 224130
		[Token(Token = "0x4036B82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036B83 RID: 224131
		[Token(Token = "0x4036B83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036B84 RID: 224132
		[Token(Token = "0x4036B84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x04036B85 RID: 224133
		[Token(Token = "0x4036B85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
