using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D75 RID: 19829
	[Token(Token = "0x2004D75")]
	public class NameCardSkinChangeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x0601DADF RID: 121567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700459C")]
		public string selectedSkinId
		{
			[Token(Token = "0x601DADF")]
			[Address(RVA = "0x1744360", Offset = "0x1742F60", VA = "0x181744360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DAE0 RID: 121568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE0")]
		[Address(RVA = "0x1743970", Offset = "0x1742570", VA = "0x181743970")]
		public void LoadData([Optional] string overrideSkinId)
		{
		}

		// Token: 0x0601DAE1 RID: 121569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE1")]
		[Address(RVA = "0x1743C00", Offset = "0x1742800", VA = "0x181743C00")]
		public void SelectSkin(string selectedId)
		{
		}

		// Token: 0x0601DAE2 RID: 121570 RVA: 0x000AC3E0 File Offset: 0x000AA5E0
		[Token(Token = "0x601DAE2")]
		[Address(RVA = "0x1743750", Offset = "0x1742350", VA = "0x181743750")]
		public bool CheckNeedChangeSkinRequest()
		{
			return default(bool);
		}

		// Token: 0x0601DAE3 RID: 121571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE3")]
		[Address(RVA = "0x1743CD0", Offset = "0x17428D0", VA = "0x181743CD0")]
		public void ToChangeSkinTmpl(string skinId)
		{
		}

		// Token: 0x0601DAE4 RID: 121572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE4")]
		[Address(RVA = "0x1743EF0", Offset = "0x1742AF0", VA = "0x181743EF0")]
		public void UpdateSkinList()
		{
		}

		// Token: 0x0601DAE5 RID: 121573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE5")]
		[Address(RVA = "0x1743870", Offset = "0x1742470", VA = "0x181743870")]
		public void HideChangeSkinTmpl()
		{
		}

		// Token: 0x0601DAE6 RID: 121574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE6")]
		[Address(RVA = "0x1743AE0", Offset = "0x17426E0", VA = "0x181743AE0")]
		public void SelectSkinTmpl(int skinTmpl)
		{
		}

		// Token: 0x0601DAE7 RID: 121575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE7")]
		[Address(RVA = "0x17440D0", Offset = "0x1742CD0", VA = "0x1817440D0")]
		private void _LoadModels(string selectedId, NameCardSkinChangeViewModel changeModel, NameCardV2ViewModel cardModel, bool isOverridden = false)
		{
		}

		// Token: 0x0601DAE8 RID: 121576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAE8")]
		[Address(RVA = "0x17441F0", Offset = "0x1742DF0", VA = "0x1817441F0")]
		public NameCardSkinChangeStateBean()
		{
		}

		// Token: 0x0402735A RID: 160602
		[Token(Token = "0x402735A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NameCardV2Property nameCardProperty;

		// Token: 0x0402735B RID: 160603
		[Token(Token = "0x402735B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NameCardSkinChangeProperty skinChangeProperty;

		// Token: 0x0402735C RID: 160604
		[Token(Token = "0x402735C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedSkinId;

		// Token: 0x0402735D RID: 160605
		[Token(Token = "0x402735D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402735E RID: 160606
		[Token(Token = "0x402735E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectSkin;

		// Token: 0x0402735F RID: 160607
		[Token(Token = "0x402735F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckNeedChangeSkinRequest;

		// Token: 0x04027360 RID: 160608
		[Token(Token = "0x4027360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToChangeSkinTmpl;

		// Token: 0x04027361 RID: 160609
		[Token(Token = "0x4027361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSkinList;

		// Token: 0x04027362 RID: 160610
		[Token(Token = "0x4027362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideChangeSkinTmpl;

		// Token: 0x04027363 RID: 160611
		[Token(Token = "0x4027363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectSkinTmpl;

		// Token: 0x04027364 RID: 160612
		[Token(Token = "0x4027364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadModels;

		// Token: 0x04027365 RID: 160613
		[Token(Token = "0x4027365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D76 RID: 19830
		[Token(Token = "0x2004D76")]
		public class RoutedNameCardSkinParam : IHotfixable
		{
			// Token: 0x1700459D RID: 17821
			// (get) Token: 0x0601DAE9 RID: 121577 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DAEA RID: 121578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700459D")]
			public string routedNameCardSkinId
			{
				[Token(Token = "0x601DAE9")]
				[Address(RVA = "0x174F8F0", Offset = "0x174E4F0", VA = "0x18174F8F0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601DAEA")]
				[Address(RVA = "0x174F950", Offset = "0x174E550", VA = "0x18174F950")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601DAEB RID: 121579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DAEB")]
			[Address(RVA = "0x174F780", Offset = "0x174E380", VA = "0x18174F780")]
			public string ConsumeRouteSkinId()
			{
				return null;
			}

			// Token: 0x0601DAEC RID: 121580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DAEC")]
			[Address(RVA = "0x174F890", Offset = "0x174E490", VA = "0x18174F890")]
			public RoutedNameCardSkinParam()
			{
			}

			// Token: 0x04027367 RID: 160615
			[Token(Token = "0x4027367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_routedNameCardSkinId;

			// Token: 0x04027368 RID: 160616
			[Token(Token = "0x4027368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_routedNameCardSkinId;

			// Token: 0x04027369 RID: 160617
			[Token(Token = "0x4027369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ConsumeRouteSkinId;

			// Token: 0x0402736A RID: 160618
			[Token(Token = "0x402736A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
