using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A3F RID: 27199
	[Token(Token = "0x2006A3F")]
	public class Main10ZoneRecordDetailView : DataBinder<Main10ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x06026E17 RID: 159255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E17")]
		[Address(RVA = "0x21EE730", Offset = "0x21ED330", VA = "0x1821EE730")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x06026E18 RID: 159256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E18")]
		[Address(RVA = "0x21EE860", Offset = "0x21ED460", VA = "0x1821EE860")]
		public void Render(RecordRewardInfo info)
		{
		}

		// Token: 0x06026E19 RID: 159257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E19")]
		[Address(RVA = "0x21EEAB0", Offset = "0x21ED6B0", VA = "0x1821EEAB0")]
		private string _TryLoadTextAssets(string path)
		{
			return null;
		}

		// Token: 0x06026E1A RID: 159258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E1A")]
		[Address(RVA = "0x21EE7B0", Offset = "0x21ED3B0", VA = "0x1821EE7B0", Slot = "7")]
		public override void OnValueChanged(Main10ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026E1B RID: 159259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E1B")]
		[Address(RVA = "0x21EE6C0", Offset = "0x21ED2C0", VA = "0x1821EE6C0")]
		public void CloseView()
		{
		}

		// Token: 0x06026E1C RID: 159260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E1C")]
		[Address(RVA = "0x21EEC90", Offset = "0x21ED890", VA = "0x1821EEC90")]
		public Main10ZoneRecordDetailView()
		{
		}

		// Token: 0x04036FAA RID: 225194
		[Token(Token = "0x4036FAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _pic;

		// Token: 0x04036FAB RID: 225195
		[Token(Token = "0x4036FAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04036FAC RID: 225196
		[Token(Token = "0x4036FAC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _normalContent;

		// Token: 0x04036FAD RID: 225197
		[Token(Token = "0x4036FAD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _content;

		// Token: 0x04036FAE RID: 225198
		[Token(Token = "0x4036FAE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _toughContent;

		// Token: 0x04036FAF RID: 225199
		[Token(Token = "0x4036FAF")]
		private const float SCROLL_DURATION = 0.23f;

		// Token: 0x04036FB0 RID: 225200
		[Token(Token = "0x4036FB0")]
		[FieldOffset(Offset = "0x48")]
		private UIPage m_page;

		// Token: 0x04036FB1 RID: 225201
		[Token(Token = "0x4036FB1")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action eventOnClose;

		// Token: 0x04036FB2 RID: 225202
		[Token(Token = "0x4036FB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04036FB3 RID: 225203
		[Token(Token = "0x4036FB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036FB4 RID: 225204
		[Token(Token = "0x4036FB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadTextAssets;

		// Token: 0x04036FB5 RID: 225205
		[Token(Token = "0x4036FB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036FB6 RID: 225206
		[Token(Token = "0x4036FB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CloseView;

		// Token: 0x04036FB7 RID: 225207
		[Token(Token = "0x4036FB7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
