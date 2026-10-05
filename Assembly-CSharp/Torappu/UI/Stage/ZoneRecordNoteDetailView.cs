using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069EE RID: 27118
	[Token(Token = "0x20069EE")]
	public class ZoneRecordNoteDetailView : DataBinder<ZoneRecordDetailViewPropery>, IHotfixable
	{
		// Token: 0x06026C7C RID: 158844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C7C")]
		[Address(RVA = "0x21E0DC0", Offset = "0x21DF9C0", VA = "0x1821E0DC0", Slot = "7")]
		public override void OnValueChanged(ZoneRecordDetailViewPropery property)
		{
		}

		// Token: 0x06026C7D RID: 158845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C7D")]
		[Address(RVA = "0x21E0EE0", Offset = "0x21DFAE0", VA = "0x1821E0EE0")]
		public void Render(RecordRewardInfo info)
		{
		}

		// Token: 0x06026C7E RID: 158846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C7E")]
		[Address(RVA = "0x21E1130", Offset = "0x21DFD30", VA = "0x1821E1130")]
		private string _TryLoadTextAssets(string path)
		{
			return null;
		}

		// Token: 0x06026C7F RID: 158847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C7F")]
		[Address(RVA = "0x21E1310", Offset = "0x21DFF10", VA = "0x1821E1310")]
		public ZoneRecordNoteDetailView()
		{
		}

		// Token: 0x04036C9C RID: 224412
		[Token(Token = "0x4036C9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZoneRecordDetailState _state;

		// Token: 0x04036C9D RID: 224413
		[Token(Token = "0x4036C9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _pic;

		// Token: 0x04036C9E RID: 224414
		[Token(Token = "0x4036C9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04036C9F RID: 224415
		[Token(Token = "0x4036C9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _normalContent;

		// Token: 0x04036CA0 RID: 224416
		[Token(Token = "0x4036CA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _content;

		// Token: 0x04036CA1 RID: 224417
		[Token(Token = "0x4036CA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _toughContent;

		// Token: 0x04036CA2 RID: 224418
		[Token(Token = "0x4036CA2")]
		private const float SCROLL_DURATION = 0.23f;

		// Token: 0x04036CA3 RID: 224419
		[Token(Token = "0x4036CA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036CA4 RID: 224420
		[Token(Token = "0x4036CA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036CA5 RID: 224421
		[Token(Token = "0x4036CA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadTextAssets;

		// Token: 0x04036CA6 RID: 224422
		[Token(Token = "0x4036CA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
