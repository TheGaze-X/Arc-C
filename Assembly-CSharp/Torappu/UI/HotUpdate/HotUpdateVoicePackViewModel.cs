using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A98 RID: 19096
	[Token(Token = "0x2004A98")]
	public class HotUpdateVoicePackViewModel : IHotfixable
	{
		// Token: 0x0601CB1D RID: 117533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB1D")]
		[Address(RVA = "0x1626620", Offset = "0x1625220", VA = "0x181626620")]
		public static HotUpdateVoicePackViewModel Create(DisplayType displayType, Dictionary<string, HotUpdateVoicePackItemData> packItemDict)
		{
			return null;
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB1E")]
		[Address(RVA = "0x1626F20", Offset = "0x1625B20", VA = "0x181626F20")]
		private static List<string> _BuildDisplayTypeList()
		{
			return null;
		}

		// Token: 0x0601CB1F RID: 117535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB1F")]
		[Address(RVA = "0x1627210", Offset = "0x1625E10", VA = "0x181627210")]
		private static string _ConvertVoiceLangToResType(VoiceLangType voiceLang)
		{
			return null;
		}

		// Token: 0x0601CB20 RID: 117536 RVA: 0x000A91A0 File Offset: 0x000A73A0
		[Token(Token = "0x601CB20")]
		[Address(RVA = "0x1626D20", Offset = "0x1625920", VA = "0x181626D20")]
		public bool IsTypeUnselectable(string voiceResType)
		{
			return default(bool);
		}

		// Token: 0x0601CB21 RID: 117537 RVA: 0x000A91B8 File Offset: 0x000A73B8
		[Token(Token = "0x601CB21")]
		[Address(RVA = "0x1626BF0", Offset = "0x16257F0", VA = "0x181626BF0")]
		public static bool IsDependentType(string voiceResType)
		{
			return default(bool);
		}

		// Token: 0x0601CB22 RID: 117538 RVA: 0x000A91D0 File Offset: 0x000A73D0
		[Token(Token = "0x601CB22")]
		[Address(RVA = "0x1626CC0", Offset = "0x16258C0", VA = "0x181626CC0")]
		public bool IsDisplayInSetting()
		{
			return default(bool);
		}

		// Token: 0x0601CB23 RID: 117539 RVA: 0x000A91E8 File Offset: 0x000A73E8
		[Token(Token = "0x601CB23")]
		[Address(RVA = "0x1626C60", Offset = "0x1625860", VA = "0x181626C60")]
		public bool IsDisplayInHotUpdate()
		{
			return default(bool);
		}

		// Token: 0x0601CB24 RID: 117540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB24")]
		[Address(RVA = "0x1626DB0", Offset = "0x16259B0", VA = "0x181626DB0")]
		public void UpdateSelectStatus(int index)
		{
		}

		// Token: 0x0601CB25 RID: 117541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB25")]
		[Address(RVA = "0x16269C0", Offset = "0x16255C0", VA = "0x1816269C0")]
		public List<string> GetAllSelectVoiceResList()
		{
			return null;
		}

		// Token: 0x0601CB26 RID: 117542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB26")]
		[Address(RVA = "0x16272E0", Offset = "0x1625EE0", VA = "0x1816272E0")]
		public HotUpdateVoicePackViewModel()
		{
		}

		// Token: 0x04025ABB RID: 154299
		[Token(Token = "0x4025ABB")]
		[FieldOffset(Offset = "0x10")]
		public List<HotUpdateVoicePackItemViewModel> itemViewModels;

		// Token: 0x04025ABC RID: 154300
		[Token(Token = "0x4025ABC")]
		[FieldOffset(Offset = "0x18")]
		public int independentValidCount;

		// Token: 0x04025ABD RID: 154301
		[Token(Token = "0x4025ABD")]
		[FieldOffset(Offset = "0x1C")]
		public int selectCount;

		// Token: 0x04025ABE RID: 154302
		[Token(Token = "0x4025ABE")]
		[FieldOffset(Offset = "0x20")]
		public DisplayType displayType;

		// Token: 0x04025ABF RID: 154303
		[Token(Token = "0x4025ABF")]
		[FieldOffset(Offset = "0x24")]
		private int dependentItemIndex;

		// Token: 0x04025AC0 RID: 154304
		[Token(Token = "0x4025AC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04025AC1 RID: 154305
		[Token(Token = "0x4025AC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BuildDisplayTypeList;

		// Token: 0x04025AC2 RID: 154306
		[Token(Token = "0x4025AC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ConvertVoiceLangToResType;

		// Token: 0x04025AC3 RID: 154307
		[Token(Token = "0x4025AC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTypeUnselectable;

		// Token: 0x04025AC4 RID: 154308
		[Token(Token = "0x4025AC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsDependentType;

		// Token: 0x04025AC5 RID: 154309
		[Token(Token = "0x4025AC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsDisplayInSetting;

		// Token: 0x04025AC6 RID: 154310
		[Token(Token = "0x4025AC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsDisplayInHotUpdate;

		// Token: 0x04025AC7 RID: 154311
		[Token(Token = "0x4025AC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateSelectStatus;

		// Token: 0x04025AC8 RID: 154312
		[Token(Token = "0x4025AC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetAllSelectVoiceResList;

		// Token: 0x04025AC9 RID: 154313
		[Token(Token = "0x4025AC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A99 RID: 19097
		[Token(Token = "0x2004A99")]
		private class VoicePackConfig
		{
			// Token: 0x0601CB27 RID: 117543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB27")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VoicePackConfig()
			{
			}

			// Token: 0x04025ACA RID: 154314
			[Token(Token = "0x4025ACA")]
			public const string DEPENDENT_VOICE_TYPE = "voice_custom";

			// Token: 0x04025ACB RID: 154315
			[Token(Token = "0x4025ACB")]
			[FieldOffset(Offset = "0x0")]
			public static HashSet<string> VOICE_TYPE_DEFAULT_SELECT_SET;
		}
	}
}
