using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006290 RID: 25232
	[Token(Token = "0x2006290")]
	public class AutoChessBandChoosePlayerListView : DataBinder<AutoChessBandChooseProperty>, IHotfixable
	{
		// Token: 0x0602461B RID: 149019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602461B")]
		[Address(RVA = "0x1F24670", Offset = "0x1F23270", VA = "0x181F24670", Slot = "7")]
		public override void OnValueChanged(AutoChessBandChooseProperty property)
		{
		}

		// Token: 0x0602461C RID: 149020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602461C")]
		[Address(RVA = "0x1F24910", Offset = "0x1F23510", VA = "0x181F24910")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602461D RID: 149021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602461D")]
		[Address(RVA = "0x1F24A30", Offset = "0x1F23630", VA = "0x181F24A30")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0602461E RID: 149022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602461E")]
		[Address(RVA = "0x1F24AF0", Offset = "0x1F236F0", VA = "0x181F24AF0")]
		public AutoChessBandChoosePlayerListView()
		{
		}

		// Token: 0x040329C4 RID: 207300
		[Token(Token = "0x40329C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040329C5 RID: 207301
		[Token(Token = "0x40329C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelPlayerBkg;

		// Token: 0x040329C6 RID: 207302
		[Token(Token = "0x40329C6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040329C7 RID: 207303
		[Token(Token = "0x40329C7")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, AutoChessBandChoosePlayerModel> m_cachedPlayerList;

		// Token: 0x040329C8 RID: 207304
		[Token(Token = "0x40329C8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isShortMode;

		// Token: 0x040329C9 RID: 207305
		[Token(Token = "0x40329C9")]
		[FieldOffset(Offset = "0x48")]
		private AutoChessBandChoosePlayerListView.Adapter m_adapter;

		// Token: 0x040329CA RID: 207306
		[Token(Token = "0x40329CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040329CB RID: 207307
		[Token(Token = "0x40329CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040329CC RID: 207308
		[Token(Token = "0x40329CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x040329CD RID: 207309
		[Token(Token = "0x40329CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006291 RID: 25233
		[Token(Token = "0x2006291")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602461F RID: 149023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602461F")]
			[Address(RVA = "0x1F22650", Offset = "0x1F21250", VA = "0x181F22650")]
			public Adapter(AutoChessBandChoosePlayerListView closure)
			{
			}

			// Token: 0x170055B6 RID: 21942
			// (get) Token: 0x06024620 RID: 149024 RVA: 0x000C40F8 File Offset: 0x000C22F8
			[Token(Token = "0x170055B6")]
			public override int count
			{
				[Token(Token = "0x6024620")]
				[Address(RVA = "0x1F226D0", Offset = "0x1F212D0", VA = "0x181F226D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024621 RID: 149025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024621")]
			[Address(RVA = "0x1F224A0", Offset = "0x1F210A0", VA = "0x181F224A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040329CE RID: 207310
			[Token(Token = "0x40329CE")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBandChoosePlayerListView m_closure;

			// Token: 0x040329CF RID: 207311
			[Token(Token = "0x40329CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040329D0 RID: 207312
			[Token(Token = "0x40329D0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040329D1 RID: 207313
			[Token(Token = "0x40329D1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
