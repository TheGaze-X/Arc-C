using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	public class RawResManager : IHotfixable
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F7")]
		public static string ROOT_DIR_PATH
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x5559220", Offset = "0x5557E20", VA = "0x185559220")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x5558FF0", Offset = "0x5557BF0", VA = "0x185558FF0")]
		public static string GetABFullPath(string resPathWithExtension)
		{
			return null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x5558D50", Offset = "0x5557950", VA = "0x185558D50")]
		public static bool CheckExist(string resPathWithExtension)
		{
			return default(bool);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x5558F00", Offset = "0x5557B00", VA = "0x185558F00")]
		public static bool EditorOnlyCheckExistWithFullPath(string resFullPathWithExtension)
		{
			return default(bool);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x5558F60", Offset = "0x5557B60", VA = "0x185558F60")]
		public static string EditorOnlyGetAssetPath(string resPathWithExt, IResLangProvider resLangOptions)
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x5559160", Offset = "0x5557D60", VA = "0x185559160")]
		private static void _OnAssetExists(string resPathWithExtension)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x55591C0", Offset = "0x5557DC0", VA = "0x1855591C0")]
		public RawResManager()
		{
		}

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		public const string AB_DIR_NAME = "raw";

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		public const string AB_DIR_PREFIX = "raw/";

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		public const string TAG_FILE_NAME = "[x]raw";

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		public const string EDITOR_PATH_SELECTOR_TYPE = "Torappu.Resource.Editor.RawResPrioritySelector";

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x0")]
		private static ILocalResourceEvents s_localResEvent;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate210 __Hotfix0_get_ROOT_DIR_PATH;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetABFullPath;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckExist;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_EditorOnlyCheckExistWithFullPath;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate3 __Hotfix0_EditorOnlyGetAssetPath;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0__OnAssetExists;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x020001CF RID: 463
		[Token(Token = "0x20001CF")]
		public interface IEditorPathSelector
		{
			// Token: 0x06000AE8 RID: 2792
			[Token(Token = "0x6000AE8")]
			string SelectBestResPath(string resPathWithExt, IResLangProvider resLangOptions);
		}
	}
}
