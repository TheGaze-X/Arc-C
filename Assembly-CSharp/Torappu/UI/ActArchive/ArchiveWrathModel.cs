using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C64 RID: 27748
	[Token(Token = "0x2006C64")]
	public class ArchiveWrathModel : IHotfixable
	{
		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x060279AA RID: 162218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D96")]
		public string selectedTypeId
		{
			[Token(Token = "0x60279AA")]
			[Address(RVA = "0x22CAA90", Offset = "0x22C9690", VA = "0x1822CAA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060279AB RID: 162219 RVA: 0x000CED60 File Offset: 0x000CCF60
		[Token(Token = "0x60279AB")]
		[Address(RVA = "0x22C9370", Offset = "0x22C7F70", VA = "0x1822C9370")]
		public bool HasNewMark()
		{
			return default(bool);
		}

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x060279AC RID: 162220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D97")]
		public WrathTypeModel currSelectedTypeModel
		{
			[Token(Token = "0x60279AC")]
			[Address(RVA = "0x22CA9D0", Offset = "0x22C95D0", VA = "0x1822CA9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060279AD RID: 162221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279AD")]
		[Address(RVA = "0x22CA020", Offset = "0x22C8C20", VA = "0x1822CA020")]
		public void SetSelectedType(string typeId)
		{
		}

		// Token: 0x060279AE RID: 162222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279AE")]
		[Address(RVA = "0x22C9550", Offset = "0x22C8150", VA = "0x1822C9550")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData)
		{
		}

		// Token: 0x060279AF RID: 162223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279AF")]
		[Address(RVA = "0x22CA300", Offset = "0x22C8F00", VA = "0x1822CA300")]
		private string _GetDefaultSelectId()
		{
			return null;
		}

		// Token: 0x060279B0 RID: 162224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B0")]
		[Address(RVA = "0x22CA6D0", Offset = "0x22C92D0", VA = "0x1822CA6D0")]
		private void _SetTypeModelSelectedStatus()
		{
		}

		// Token: 0x060279B1 RID: 162225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B1")]
		[Address(RVA = "0x22CA3E0", Offset = "0x22C8FE0", VA = "0x1822CA3E0")]
		private void _RefreshTypeModelHasNewStatus()
		{
		}

		// Token: 0x060279B2 RID: 162226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B2")]
		[Address(RVA = "0x22CA920", Offset = "0x22C9520", VA = "0x1822CA920")]
		public ArchiveWrathModel()
		{
		}

		// Token: 0x040382CC RID: 230092
		[Token(Token = "0x40382CC")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, WrathTypeModel> wrathTypeModels;

		// Token: 0x040382CD RID: 230093
		[Token(Token = "0x40382CD")]
		[FieldOffset(Offset = "0x18")]
		public ArchiveWrathModel.SwitchType switchType;

		// Token: 0x040382CE RID: 230094
		[Token(Token = "0x40382CE")]
		[FieldOffset(Offset = "0x20")]
		public string m_selectedTypeId;

		// Token: 0x040382CF RID: 230095
		[Token(Token = "0x40382CF")]
		[FieldOffset(Offset = "0x28")]
		private bool m_cachedAttained;

		// Token: 0x040382D0 RID: 230096
		[Token(Token = "0x40382D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTypeId;

		// Token: 0x040382D1 RID: 230097
		[Token(Token = "0x40382D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasNewMark;

		// Token: 0x040382D2 RID: 230098
		[Token(Token = "0x40382D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currSelectedTypeModel;

		// Token: 0x040382D3 RID: 230099
		[Token(Token = "0x40382D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectedType;

		// Token: 0x040382D4 RID: 230100
		[Token(Token = "0x40382D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040382D5 RID: 230101
		[Token(Token = "0x40382D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetDefaultSelectId;

		// Token: 0x040382D6 RID: 230102
		[Token(Token = "0x40382D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetTypeModelSelectedStatus;

		// Token: 0x040382D7 RID: 230103
		[Token(Token = "0x40382D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshTypeModelHasNewStatus;

		// Token: 0x040382D8 RID: 230104
		[Token(Token = "0x40382D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C65 RID: 27749
		[Token(Token = "0x2006C65")]
		public enum SwitchType
		{
			// Token: 0x040382DA RID: 230106
			[Token(Token = "0x40382DA")]
			NONE,
			// Token: 0x040382DB RID: 230107
			[Token(Token = "0x40382DB")]
			DEFAULT,
			// Token: 0x040382DC RID: 230108
			[Token(Token = "0x40382DC")]
			TO_COLOR,
			// Token: 0x040382DD RID: 230109
			[Token(Token = "0x40382DD")]
			TO_BLACK
		}
	}
}
