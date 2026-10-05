using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200694A RID: 26954
	[Token(Token = "0x200694A")]
	public class StageButtonHolderBuildinComps : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x06026966 RID: 158054 RVA: 0x000CBC28 File Offset: 0x000C9E28
		[Token(Token = "0x17005B1A")]
		public bool enableColorGraphicBinding
		{
			[Token(Token = "0x6026966")]
			[Address(RVA = "0x21A7E70", Offset = "0x21A6A70", VA = "0x1821A7E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026967 RID: 158055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026967")]
		[Address(RVA = "0x21A7E10", Offset = "0x21A6A10", VA = "0x1821A7E10")]
		public StageButtonHolderBuildinComps()
		{
		}

		// Token: 0x0403670E RID: 222990
		[Token(Token = "0x403670E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enableColorGraphicBinding;

		// Token: 0x0403670F RID: 222991
		[Token(Token = "0x403670F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enableColorGraphicBinding;

		// Token: 0x04036710 RID: 222992
		[Token(Token = "0x4036710")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200694B RID: 26955
		[Token(Token = "0x200694B")]
		public class ColorGraphicBinding : StageButtonOnMapHolder.SingleComp
		{
			// Token: 0x06026968 RID: 158056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026968")]
			[Address(RVA = "0x21A6610", Offset = "0x21A5210", VA = "0x1821A6610")]
			public void SetTarget(string funcKey, UIColorGraphic target)
			{
			}

			// Token: 0x06026969 RID: 158057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026969")]
			[Address(RVA = "0x21A6420", Offset = "0x21A5020", VA = "0x1821A6420")]
			public void AddGraphic(string funcKey, Graphic graphic)
			{
			}

			// Token: 0x0602696A RID: 158058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602696A")]
			[Address(RVA = "0x21A6850", Offset = "0x21A5450", VA = "0x1821A6850")]
			private StageButtonHolderBuildinComps.ColorGraphicBinding.BindItem _EnsureItem(string funcKey)
			{
				return null;
			}

			// Token: 0x0602696B RID: 158059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602696B")]
			[Address(RVA = "0x21A6A90", Offset = "0x21A5690", VA = "0x1821A6A90")]
			private void _RemoveInvalidItems()
			{
			}

			// Token: 0x0602696C RID: 158060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602696C")]
			[Address(RVA = "0x21A6C30", Offset = "0x21A5830", VA = "0x1821A6C30")]
			public ColorGraphicBinding()
			{
			}

			// Token: 0x04036711 RID: 222993
			[Token(Token = "0x4036711")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<string, StageButtonHolderBuildinComps.ColorGraphicBinding.BindItem> m_bindings;

			// Token: 0x04036712 RID: 222994
			[Token(Token = "0x4036712")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetTarget;

			// Token: 0x04036713 RID: 222995
			[Token(Token = "0x4036713")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AddGraphic;

			// Token: 0x04036714 RID: 222996
			[Token(Token = "0x4036714")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__EnsureItem;

			// Token: 0x04036715 RID: 222997
			[Token(Token = "0x4036715")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__RemoveInvalidItems;

			// Token: 0x04036716 RID: 222998
			[Token(Token = "0x4036716")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200694C RID: 26956
			[Token(Token = "0x200694C")]
			private class BindItem : IHotfixable
			{
				// Token: 0x0602696D RID: 158061 RVA: 0x000CBC40 File Offset: 0x000C9E40
				[Token(Token = "0x602696D")]
				[Address(RVA = "0x21A6150", Offset = "0x21A4D50", VA = "0x1821A6150")]
				public bool IsInvalid()
				{
					return default(bool);
				}

				// Token: 0x0602696E RID: 158062 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602696E")]
				[Address(RVA = "0x21A61F0", Offset = "0x21A4DF0", VA = "0x1821A61F0")]
				public void SetTarget(UIColorGraphic target)
				{
				}

				// Token: 0x0602696F RID: 158063 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602696F")]
				[Address(RVA = "0x21A6030", Offset = "0x21A4C30", VA = "0x1821A6030")]
				public void AddGraphic(Graphic graphic)
				{
				}

				// Token: 0x06026970 RID: 158064 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6026970")]
				[Address(RVA = "0x21A6370", Offset = "0x21A4F70", VA = "0x1821A6370")]
				public BindItem()
				{
				}

				// Token: 0x04036717 RID: 222999
				[Token(Token = "0x4036717")]
				[FieldOffset(Offset = "0x10")]
				private UIColorGraphic m_target;

				// Token: 0x04036718 RID: 223000
				[Token(Token = "0x4036718")]
				[FieldOffset(Offset = "0x18")]
				private object m_refMark;

				// Token: 0x04036719 RID: 223001
				[Token(Token = "0x4036719")]
				[FieldOffset(Offset = "0x20")]
				private List<Graphic> m_pendings;

				// Token: 0x0403671A RID: 223002
				[Token(Token = "0x403671A")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_IsInvalid;

				// Token: 0x0403671B RID: 223003
				[Token(Token = "0x403671B")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_SetTarget;

				// Token: 0x0403671C RID: 223004
				[Token(Token = "0x403671C")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_AddGraphic;

				// Token: 0x0403671D RID: 223005
				[Token(Token = "0x403671D")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}
	}
}
