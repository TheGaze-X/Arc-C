using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020006C5 RID: 1733
	[Token(Token = "0x20006C5")]
	public class CharRotationUpdatePresetRequest
	{
		// Token: 0x0600630E RID: 25358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharRotationUpdatePresetRequest()
		{
		}

		// Token: 0x04002EB6 RID: 11958
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x18")]
		public CharRotationUpdatePresetRequest.UpdateFlag flag;

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x20")]
		public CharRotationUpdatePresetRequest.PresetData data;

		// Token: 0x020006C6 RID: 1734
		[Token(Token = "0x20006C6")]
		[Flags]
		public enum UpdateFlag
		{
			// Token: 0x04002EBA RID: 11962
			[Token(Token = "0x4002EBA")]
			PRESET_NAME = 1,
			// Token: 0x04002EBB RID: 11963
			[Token(Token = "0x4002EBB")]
			HOME_BACKGROUND = 2,
			// Token: 0x04002EBC RID: 11964
			[Token(Token = "0x4002EBC")]
			HOME_THEME = 4,
			// Token: 0x04002EBD RID: 11965
			[Token(Token = "0x4002EBD")]
			PRESET_SECRETARY = 8,
			// Token: 0x04002EBE RID: 11966
			[Token(Token = "0x4002EBE")]
			PRESET_SLOTS = 16
		}

		// Token: 0x020006C7 RID: 1735
		[Token(Token = "0x20006C7")]
		[Serializable]
		public class Slot
		{
			// Token: 0x0600630F RID: 25359 RVA: 0x00030378 File Offset: 0x0002E578
			[Token(Token = "0x600630F")]
			[Address(RVA = "0x1DF73C0", Offset = "0x1DF5FC0", VA = "0x181DF73C0")]
			public CharUISkinStruct GetSkinStruct()
			{
				return default(CharUISkinStruct);
			}

			// Token: 0x06006310 RID: 25360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006310")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Slot()
			{
			}

			// Token: 0x04002EBF RID: 11967
			[Token(Token = "0x4002EBF")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04002EC0 RID: 11968
			[Token(Token = "0x4002EC0")]
			[FieldOffset(Offset = "0x18")]
			public string skinId;

			// Token: 0x04002EC1 RID: 11969
			[Token(Token = "0x4002EC1")]
			[FieldOffset(Offset = "0x20")]
			public bool skinSp;
		}

		// Token: 0x020006C8 RID: 1736
		[Token(Token = "0x20006C8")]
		[Serializable]
		public class PresetData
		{
			// Token: 0x06006311 RID: 25361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006311")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PresetData()
			{
			}

			// Token: 0x04002EC2 RID: 11970
			[Token(Token = "0x4002EC2")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04002EC3 RID: 11971
			[Token(Token = "0x4002EC3")]
			[FieldOffset(Offset = "0x18")]
			public string background;

			// Token: 0x04002EC4 RID: 11972
			[Token(Token = "0x4002EC4")]
			[FieldOffset(Offset = "0x20")]
			public string homeTheme;

			// Token: 0x04002EC5 RID: 11973
			[Token(Token = "0x4002EC5")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("profile")]
			public string secretarySkinId;

			// Token: 0x04002EC6 RID: 11974
			[Token(Token = "0x4002EC6")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("profileInst")]
			public string secretaryCharInstId;

			// Token: 0x04002EC7 RID: 11975
			[Token(Token = "0x4002EC7")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty("profileSp")]
			public bool secretaryShowSpDynIllust;

			// Token: 0x04002EC8 RID: 11976
			[Token(Token = "0x4002EC8")]
			[FieldOffset(Offset = "0x40")]
			public List<CharRotationUpdatePresetRequest.Slot> slots;
		}
	}
}
