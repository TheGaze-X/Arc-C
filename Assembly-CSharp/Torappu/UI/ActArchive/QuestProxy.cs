using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD3 RID: 27347
	[Token(Token = "0x2006AD3")]
	public class QuestProxy : ActArchiveCompProxy<ArchiveQuestController>
	{
		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x060271E1 RID: 160225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C76")]
		protected override string compType
		{
			[Token(Token = "0x60271E1")]
			[Address(RVA = "0x2260600", Offset = "0x225F200", VA = "0x182260600", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271E2 RID: 160226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271E2")]
		[Address(RVA = "0x225F4F0", Offset = "0x225E0F0", VA = "0x18225F4F0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271E3 RID: 160227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E3")]
		[Address(RVA = "0x225F560", Offset = "0x225E160", VA = "0x18225F560", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271E4 RID: 160228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E4")]
		[Address(RVA = "0x225F880", Offset = "0x225E480", VA = "0x18225F880")]
		private void OnSelectQuestType(SandboxV2ArchiveQuestType type)
		{
		}

		// Token: 0x060271E5 RID: 160229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E5")]
		[Address(RVA = "0x2260120", Offset = "0x225ED20", VA = "0x182260120")]
		private void _OnItemSelect(int index)
		{
		}

		// Token: 0x060271E6 RID: 160230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E6")]
		[Address(RVA = "0x225FA10", Offset = "0x225E610", VA = "0x18225FA10")]
		public void StartAvgAndBackToArchiveAvg(StoryData targetStory)
		{
		}

		// Token: 0x060271E7 RID: 160231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271E7")]
		[Address(RVA = "0x225FDA0", Offset = "0x225E9A0", VA = "0x18225FDA0")]
		private DataBundle _GenerateDataBundleToAvg()
		{
			return null;
		}

		// Token: 0x060271E8 RID: 160232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271E8")]
		[Address(RVA = "0x22602B0", Offset = "0x225EEB0", VA = "0x1822602B0")]
		private UIPageControllerParam _SceneParamToState(DataBundle bundleToState)
		{
			return null;
		}

		// Token: 0x060271E9 RID: 160233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E9")]
		[Address(RVA = "0x225FFA0", Offset = "0x225EBA0", VA = "0x18225FFA0")]
		private void _OnFullscreenToggled(bool isFullScreen)
		{
		}

		// Token: 0x060271EA RID: 160234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271EA")]
		[Address(RVA = "0x2260590", Offset = "0x225F190", VA = "0x182260590")]
		public QuestProxy()
		{
		}

		// Token: 0x04037550 RID: 226640
		[Token(Token = "0x4037550")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037551 RID: 226641
		[Token(Token = "0x4037551")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037552 RID: 226642
		[Token(Token = "0x4037552")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037553 RID: 226643
		[Token(Token = "0x4037553")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectQuestType;

		// Token: 0x04037554 RID: 226644
		[Token(Token = "0x4037554")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemSelect;

		// Token: 0x04037555 RID: 226645
		[Token(Token = "0x4037555")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StartAvgAndBackToArchiveAvg;

		// Token: 0x04037556 RID: 226646
		[Token(Token = "0x4037556")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateDataBundleToAvg;

		// Token: 0x04037557 RID: 226647
		[Token(Token = "0x4037557")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SceneParamToState;

		// Token: 0x04037558 RID: 226648
		[Token(Token = "0x4037558")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnFullscreenToggled;

		// Token: 0x04037559 RID: 226649
		[Token(Token = "0x4037559")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
