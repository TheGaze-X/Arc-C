using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068DC RID: 26844
	[Token(Token = "0x20068DC")]
	public class ActivityCustomZoneStageButton : MonoBehaviour, IActivityCustomZoneStageButton, IHotfixable
	{
		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x06026758 RID: 157528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026759 RID: 157529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AD6")]
		public string stageId
		{
			[Token(Token = "0x6026758")]
			[Address(RVA = "0x21779A0", Offset = "0x21765A0", VA = "0x1821779A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6026759")]
			[Address(RVA = "0x2177A80", Offset = "0x2176680", VA = "0x182177A80", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x0602675A RID: 157530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602675B RID: 157531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AD7")]
		public Action<string> onStageBtnClicked
		{
			[Token(Token = "0x602675A")]
			[Address(RVA = "0x2177940", Offset = "0x2176540", VA = "0x182177940")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602675B")]
			[Address(RVA = "0x2177A00", Offset = "0x2176600", VA = "0x182177A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602675C RID: 157532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602675C")]
		[Address(RVA = "0x2177750", Offset = "0x2176350", VA = "0x182177750", Slot = "6")]
		public void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode)
		{
		}

		// Token: 0x0602675D RID: 157533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602675D")]
		[Address(RVA = "0x21775F0", Offset = "0x21761F0", VA = "0x1821775F0")]
		public void OnStageBtnClicked()
		{
		}

		// Token: 0x0602675E RID: 157534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602675E")]
		[Address(RVA = "0x21778E0", Offset = "0x21764E0", VA = "0x1821778E0")]
		public ActivityCustomZoneStageButton()
		{
		}

		// Token: 0x040362ED RID: 221933
		[Token(Token = "0x40362ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _stageId;

		// Token: 0x040362EE RID: 221934
		[Token(Token = "0x40362EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityCustomZoneBaseStageButtonPlugin[] _plugins;

		// Token: 0x040362F0 RID: 221936
		[Token(Token = "0x40362F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x040362F1 RID: 221937
		[Token(Token = "0x40362F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_stageId;

		// Token: 0x040362F2 RID: 221938
		[Token(Token = "0x40362F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onStageBtnClicked;

		// Token: 0x040362F3 RID: 221939
		[Token(Token = "0x40362F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onStageBtnClicked;

		// Token: 0x040362F4 RID: 221940
		[Token(Token = "0x40362F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040362F5 RID: 221941
		[Token(Token = "0x40362F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStageBtnClicked;

		// Token: 0x040362F6 RID: 221942
		[Token(Token = "0x40362F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
