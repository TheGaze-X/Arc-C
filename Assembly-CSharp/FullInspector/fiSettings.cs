using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BCB RID: 31691
	[Token(Token = "0x2007BCB")]
	public class fiSettings
	{
		// Token: 0x0602C5B7 RID: 181687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5B7")]
		[Address(RVA = "0x2872D60", Offset = "0x2871960", VA = "0x182872D60")]
		private static void EnsureRootDirectory()
		{
		}

		// Token: 0x0602C5B8 RID: 181688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5B8")]
		[Address(RVA = "0x2873290", Offset = "0x2871E90", VA = "0x182873290")]
		private static string FormatCustomizerForNewPath(string path)
		{
			return null;
		}

		// Token: 0x0602C5B9 RID: 181689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5B9")]
		[Address(RVA = "0x2872FE0", Offset = "0x2871BE0", VA = "0x182872FE0")]
		private static string FindDirectoryPathByName(string currentDirectory, string targetDirectory)
		{
			return null;
		}

		// Token: 0x0602C5BA RID: 181690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiSettings()
		{
		}

		// Token: 0x0404022D RID: 262701
		[Token(Token = "0x404022D")]
		[FieldOffset(Offset = "0x0")]
		public static bool EnableLogs;

		// Token: 0x0404022E RID: 262702
		[Token(Token = "0x404022E")]
		[FieldOffset(Offset = "0x1")]
		public static bool PrettyPrintSerializedJson;

		// Token: 0x0404022F RID: 262703
		[Token(Token = "0x404022F")]
		[FieldOffset(Offset = "0x4")]
		public static CommentType DefaultCommentType;

		// Token: 0x04040230 RID: 262704
		[Token(Token = "0x4040230")]
		[FieldOffset(Offset = "0x8")]
		public static bool ForceDisplayInlineObjectEditor;

		// Token: 0x04040231 RID: 262705
		[Token(Token = "0x4040231")]
		[FieldOffset(Offset = "0x9")]
		public static bool EnableAnimation;

		// Token: 0x04040232 RID: 262706
		[Token(Token = "0x4040232")]
		[FieldOffset(Offset = "0xA")]
		public static bool ForceSaveAllAssetsOnSceneSave;

		// Token: 0x04040233 RID: 262707
		[Token(Token = "0x4040233")]
		[FieldOffset(Offset = "0xB")]
		public static bool ForceSaveAllAssetsOnRecompilation;

		// Token: 0x04040234 RID: 262708
		[Token(Token = "0x4040234")]
		[FieldOffset(Offset = "0xC")]
		public static bool ForceRestoreAllAssetsOnRecompilation;

		// Token: 0x04040235 RID: 262709
		[Token(Token = "0x4040235")]
		[FieldOffset(Offset = "0xD")]
		public static bool AutomaticReferenceInstantation;

		// Token: 0x04040236 RID: 262710
		[Token(Token = "0x4040236")]
		[FieldOffset(Offset = "0xE")]
		public static bool InspectorAutomaticReferenceInstantation;

		// Token: 0x04040237 RID: 262711
		[Token(Token = "0x4040237")]
		[FieldOffset(Offset = "0xF")]
		public static bool InspectorRequireShowInInspector;

		// Token: 0x04040238 RID: 262712
		[Token(Token = "0x4040238")]
		[FieldOffset(Offset = "0x10")]
		public static bool SerializeAutoProperties;

		// Token: 0x04040239 RID: 262713
		[Token(Token = "0x4040239")]
		[FieldOffset(Offset = "0x11")]
		public static bool EmitWarnings;

		// Token: 0x0404023A RID: 262714
		[Token(Token = "0x404023A")]
		[FieldOffset(Offset = "0x12")]
		public static bool EmitGraphMetadataCulls;

		// Token: 0x0404023B RID: 262715
		[Token(Token = "0x404023B")]
		[FieldOffset(Offset = "0x14")]
		public static float MinimumFoldoutHeight;

		// Token: 0x0404023C RID: 262716
		[Token(Token = "0x404023C")]
		[FieldOffset(Offset = "0x18")]
		public static bool EnableOpenScriptButton;

		// Token: 0x0404023D RID: 262717
		[Token(Token = "0x404023D")]
		[FieldOffset(Offset = "0x19")]
		public static bool ForceDisableMultithreadedSerialization;

		// Token: 0x0404023E RID: 262718
		[Token(Token = "0x404023E")]
		[FieldOffset(Offset = "0x1C")]
		public static float LabelWidthPercentage;

		// Token: 0x0404023F RID: 262719
		[Token(Token = "0x404023F")]
		[FieldOffset(Offset = "0x20")]
		public static float LabelWidthOffset;

		// Token: 0x04040240 RID: 262720
		[Token(Token = "0x4040240")]
		[FieldOffset(Offset = "0x24")]
		public static float LabelWidthMax;

		// Token: 0x04040241 RID: 262721
		[Token(Token = "0x4040241")]
		[FieldOffset(Offset = "0x28")]
		public static float LabelWidthMin;

		// Token: 0x04040242 RID: 262722
		[Token(Token = "0x4040242")]
		[FieldOffset(Offset = "0x2C")]
		public static bool DisplaySingleCategory;

		// Token: 0x04040243 RID: 262723
		[Token(Token = "0x4040243")]
		[FieldOffset(Offset = "0x30")]
		public static int DefaultPageMinimumCollectionLength;

		// Token: 0x04040244 RID: 262724
		[Token(Token = "0x4040244")]
		[FieldOffset(Offset = "0x38")]
		public static string RootDirectory;

		// Token: 0x04040245 RID: 262725
		[Token(Token = "0x4040245")]
		[FieldOffset(Offset = "0x40")]
		public static string RootGeneratedDirectory;
	}
}
