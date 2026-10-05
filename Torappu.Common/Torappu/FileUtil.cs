using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Torappu
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public static class FileUtil
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x5519650", Offset = "0x5518250", VA = "0x185519650")]
		private static string _GetAppDataPath()
		{
			return null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5518320", Offset = "0x5516F20", VA = "0x185518320")]
		public static string FullPathToAssetPath(string path)
		{
			return null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x55175D0", Offset = "0x55161D0", VA = "0x1855175D0")]
		public static string AssetPathToFullPath(string path)
		{
			return null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x5517660", Offset = "0x5516260", VA = "0x185517660")]
		public static string AssetPathToRuntimeResourcePath(string path, [Optional] string fileExt)
		{
			return null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x55190B0", Offset = "0x5517CB0", VA = "0x1855190B0")]
		public static string StripExtension(string path)
		{
			return null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x5519130", Offset = "0x5517D30", VA = "0x185519130")]
		public static string StripPathPrefix(string path, string prefix)
		{
			return null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x5518DE0", Offset = "0x55179E0", VA = "0x185518DE0")]
		public static string ReplaceExtension(string path, string newExt)
		{
			return null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x5518F80", Offset = "0x5517B80", VA = "0x185518F80")]
		public static string ReplacePrefixWithExtension(string path, string prefix)
		{
			return null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x5518EB0", Offset = "0x5517AB0", VA = "0x185518EB0")]
		public static string ReplacePrefixButKeepExtension(string path, string prefix)
		{
			return null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5518860", Offset = "0x5517460", VA = "0x185518860")]
		public static string OverwritePathPrefix(string path, string oldPrefix, string newPrefix)
		{
			return null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x5517CB0", Offset = "0x55168B0", VA = "0x185517CB0")]
		public static void CreateFolderOrCleanupIfExists(string folderPath)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x5517BF0", Offset = "0x55167F0", VA = "0x185517BF0")]
		public static bool CreateFolderIfNotExists(string folderPath)
		{
			return default(bool);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x55182B0", Offset = "0x5516EB0", VA = "0x1855182B0")]
		public static string FixPathForLong(string path)
		{
			return null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x5517A60", Offset = "0x5516660", VA = "0x185517A60")]
		public static string Combine(string path1, string path2)
		{
			return null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x55178A0", Offset = "0x55164A0", VA = "0x1855178A0")]
		public static string Combine(string path1, string path2, string path3)
		{
			return null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x55177B0", Offset = "0x55163B0", VA = "0x1855177B0")]
		public static bool CheckPathEqual(string path1, string path2)
		{
			return default(bool);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x5519360", Offset = "0x5517F60", VA = "0x185519360")]
		public static string Trim(string path)
		{
			return null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x5518100", Offset = "0x5516D00", VA = "0x185518100")]
		public static void DeleteIfExists(string path)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x5517F30", Offset = "0x5516B30", VA = "0x185517F30")]
		public static void DeleteDirectoryIfExists(string directory)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x5518260", Offset = "0x5516E60", VA = "0x185518260")]
		public static void DeleteWithMeta(string path)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5518090", Offset = "0x5516C90", VA = "0x185518090")]
		public static void DeleteFolderWithMeta(string path, bool recursive)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5518780", Offset = "0x5517380", VA = "0x185518780")]
		public static void MoveWithMeta(string originPath, string newPath)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x5518600", Offset = "0x5517200", VA = "0x185518600")]
		public static void MoveAdvanced(string sourceFileName, string destFileName, bool overwrite)
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5518500", Offset = "0x5517100", VA = "0x185518500")]
		public static string GetPrettySizeString(long size)
		{
			return null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x5518580", Offset = "0x5517180", VA = "0x185518580")]
		public static string GetPrettySizeString(long size, string formatStr)
		{
			return null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x55184A0", Offset = "0x55170A0", VA = "0x1855184A0")]
		public static string GetPrettySizeStringUpToMB(long size, string formatStr)
		{
			return null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x5518430", Offset = "0x5517030", VA = "0x185518430")]
		public static string GetPrettySizeStringUpToMB(long size)
		{
			return null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x5519730", Offset = "0x5518330", VA = "0x185519730")]
		private static string _GetPrettySizeString(long size, string formatStr, int untilSuffixIndex)
		{
			return null;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x5518CC0", Offset = "0x55178C0", VA = "0x185518CC0")]
		public static string ReadFileContentOrNull(string path)
		{
			return null;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x55191C0", Offset = "0x5517DC0", VA = "0x1855191C0")]
		public static void TranverseDirectory(string path, Action<string> onFile, [Optional] Func<string, bool> onDir)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x5519500", Offset = "0x5518100", VA = "0x185519500")]
		public static void WriteToFile(string content, string path, bool useRetry = false)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x5519940", Offset = "0x5518540", VA = "0x185519940")]
		private static void _WriteToFileAction(string content, string path)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5519030", Offset = "0x5517C30", VA = "0x185519030")]
		public static void RetryIO(Action opt)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000585")]
		public static T RetryIOResult<T>(Func<T> opt)
		{
			return null;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x55193B0", Offset = "0x5517FB0", VA = "0x1855193B0")]
		public static void WriteBytesToFile(byte[] bytes, string path, bool useRetry = false)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x5519890", Offset = "0x5518490", VA = "0x185519890")]
		private static void _WriteBytesOpt(byte[] bytes, string path)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x55183B0", Offset = "0x5516FB0", VA = "0x1855183B0")]
		public static long GetFileInfoLength(string fullPath)
		{
			return 0L;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x5518A10", Offset = "0x5517610", VA = "0x185518A10")]
		public static Exception ReadAllBytes(string path, bool isStreaming, out byte[] bytes, out bool fileExists)
		{
			return null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x55189C0", Offset = "0x55175C0", VA = "0x1855189C0")]
		public static string PersistentFileStorageRoot()
		{
			return null;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x5518AD0", Offset = "0x55176D0", VA = "0x185518AD0")]
		public static void ReadAllTextFromStreamingFileSync(string streamingFilePath, FileUtil.StreamingResult result)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x5518C30", Offset = "0x5517830", VA = "0x185518C30")]
		public static IEnumerator ReadAllTextFromStreamingFile(string streamingFilePath, FileUtil.StreamingResult result)
		{
			return null;
		}

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] SIZE_SUFFIXS;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		private const string DEFAULT_PRETTY_SIZE_FORMAT_STR = "F2";

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		private const int IO_RETRY_COUNT = 3;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string s_dataPathCache;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		public const string RAW_RES_ROOT_DIR = "Assets/Torappu/RawAssets";

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int MaxShortPathLength;

		// Token: 0x020000E9 RID: 233
		[Token(Token = "0x20000E9")]
		public class StreamingResult
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x00005CCC File Offset: 0x00003ECC
			// (set) Token: 0x0600058F RID: 1423 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000068")]
			public long respCode
			{
				[Token(Token = "0x600058E")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x600058F")]
				[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000591 RID: 1425 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000069")]
			public byte[] bytes
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000591")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000593 RID: 1427 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700006A")]
			public string text
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x00005CE4 File Offset: 0x00003EE4
			// (set) Token: 0x06000595 RID: 1429 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700006B")]
			public bool isError
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000597 RID: 1431 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700006C")]
			public string errorInfo
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x00005CFC File Offset: 0x00003EFC
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x5526DB0", Offset = "0x55259B0", VA = "0x185526DB0")]
			public bool FileNotExists()
			{
				return default(bool);
			}

			// Token: 0x06000599 RID: 1433 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x5526DD0", Offset = "0x55259D0", VA = "0x185526DD0")]
			public void MarkAsError(long responseCode, string error)
			{
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x5526E70", Offset = "0x5525A70", VA = "0x185526E70")]
			public void MarkAsSucceed(DownloadHandler downloadHandler)
			{
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x5526E40", Offset = "0x5525A40", VA = "0x185526E40")]
			public void MarkAsSucceed(string text)
			{
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x5526D70", Offset = "0x5525970", VA = "0x185526D70")]
			public void Clear()
			{
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StreamingResult()
			{
			}
		}
	}
}
