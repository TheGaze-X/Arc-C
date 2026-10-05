using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200779D RID: 30621
	[Token(Token = "0x200779D")]
	public class Act1VHalfIdleDepotBuffView : DataBinder<Act1VHalfIdleDepotBuffProp>
	{
		// Token: 0x0602AFEA RID: 176106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFEA")]
		[Address(RVA = "0x26CA240", Offset = "0x26C8E40", VA = "0x1826CA240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AFEB RID: 176107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFEB")]
		[Address(RVA = "0x26CA060", Offset = "0x26C8C60", VA = "0x1826CA060", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleDepotBuffProp property)
		{
		}

		// Token: 0x0602AFEC RID: 176108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFEC")]
		[Address(RVA = "0x26CA360", Offset = "0x26C8F60", VA = "0x1826CA360")]
		public Act1VHalfIdleDepotBuffView()
		{
		}

		// Token: 0x0403E0EE RID: 254190
		[Token(Token = "0x403E0EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403E0EF RID: 254191
		[Token(Token = "0x403E0EF")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403E0F0 RID: 254192
		[Token(Token = "0x403E0F0")]
		[FieldOffset(Offset = "0x2C")]
		private int m_cachedEnterSeq;

		// Token: 0x0403E0F1 RID: 254193
		[Token(Token = "0x403E0F1")]
		[FieldOffset(Offset = "0x30")]
		private Act1VHalfIdleDepotBuffView.Adapter m_adapter;

		// Token: 0x0403E0F2 RID: 254194
		[Token(Token = "0x403E0F2")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdleDepotBuffViewModel m_cachedViewModel;

		// Token: 0x0403E0F3 RID: 254195
		[Token(Token = "0x403E0F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E0F4 RID: 254196
		[Token(Token = "0x403E0F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E0F5 RID: 254197
		[Token(Token = "0x403E0F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200779E RID: 30622
		[Token(Token = "0x200779E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602AFED RID: 176109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AFED")]
			[Address(RVA = "0x26D6E10", Offset = "0x26D5A10", VA = "0x1826D6E10")]
			public Adapter(Act1VHalfIdleDepotBuffView closure)
			{
			}

			// Token: 0x170064C3 RID: 25795
			// (get) Token: 0x0602AFEE RID: 176110 RVA: 0x000DA958 File Offset: 0x000D8B58
			[Token(Token = "0x170064C3")]
			public override int count
			{
				[Token(Token = "0x602AFEE")]
				[Address(RVA = "0x26D6E90", Offset = "0x26D5A90", VA = "0x1826D6E90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AFEF RID: 176111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AFEF")]
			[Address(RVA = "0x26D6C10", Offset = "0x26D5810", VA = "0x1826D6C10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E0F6 RID: 254198
			[Token(Token = "0x403E0F6")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleDepotBuffView m_closure;

			// Token: 0x0403E0F7 RID: 254199
			[Token(Token = "0x403E0F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E0F8 RID: 254200
			[Token(Token = "0x403E0F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E0F9 RID: 254201
			[Token(Token = "0x403E0F9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
