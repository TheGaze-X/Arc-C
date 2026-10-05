using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public class ImageSaver
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4A0C6A0", Offset = "0x4A0B2A0", VA = "0x184A0C6A0")]
		public Task SaveImage(string paramJson)
		{
			return null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4A0C430", Offset = "0x4A0B030", VA = "0x184A0C430")]
		public Task<bool> SaveCloudGameImage(string paramJson)
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4A0CE30", Offset = "0x4A0BA30", VA = "0x184A0CE30")]
		private bool ValidateInput(string paramJson, out ImageSaver.ImageShareInfo shareInfo)
		{
			return default(bool);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4A0C230", Offset = "0x4A0AE30", VA = "0x184A0C230")]
		private string NormalizeSourcePath(string imgPath)
		{
			return null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4A0C360", Offset = "0x4A0AF60", VA = "0x184A0C360")]
		private ImageSaver.FolderType ParseFolderType(int folderType)
		{
			return ImageSaver.FolderType.UserPicturesFolder;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4A0B8B0", Offset = "0x4A0A4B0", VA = "0x184A0B8B0")]
		private string BuildTargetPath(string sourcePath, string relativePath, string baseFolder)
		{
			return null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4A0BF70", Offset = "0x4A0AB70", VA = "0x184A0BF70")]
		private bool IsDirectoryPath(string path)
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4A0B730", Offset = "0x4A0A330", VA = "0x184A0B730")]
		private string BuildPathForDirectory(string sourcePath, string relativeDirPath, string baseFolder)
		{
			return null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4A0C540", Offset = "0x4A0B140", VA = "0x184A0C540")]
		private Task<bool> SaveImageToPathAsync(string sourcePath, string targetPath, string imgFolder)
		{
			return null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4A0C030", Offset = "0x4A0AC30", VA = "0x184A0C030")]
		private bool IsSamePath(string sourcePath, string targetPath)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4A0CF70", Offset = "0x4A0BB70", VA = "0x184A0CF70")]
		private bool ValidateMove(string sourcePath, string targetPath, string rootDir, out string error)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4A0BB90", Offset = "0x4A0A790", VA = "0x184A0BB90")]
		private void EnsureDirectoryExists(string filePath)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4A0C0B0", Offset = "0x4A0ACB0", VA = "0x184A0C0B0")]
		private bool MoveFile(string sourcePath, string targetPath)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4A0BDA0", Offset = "0x4A0A9A0", VA = "0x184A0BDA0")]
		private string GetImageSaveFolder(ImageSaver.FolderType folderType)
		{
			return null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4A0BE60", Offset = "0x4A0AA60", VA = "0x184A0BE60")]
		private string GetWindowsPicturePath()
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4A0BC10", Offset = "0x4A0A810", VA = "0x184A0BC10")]
		private string GetGameInstalledFolder()
		{
			return null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4A0CD30", Offset = "0x4A0B930", VA = "0x184A0CD30")]
		private void SendSuccessResponse(string targetPath)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4A0C7A0", Offset = "0x4A0B3A0", VA = "0x184A0C7A0")]
		private void SendErrorResponse(ImageSaver.ErrorCode errorCode)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4A0C970", Offset = "0x4A0B570", VA = "0x184A0C970")]
		private void SendResponse(ImageSaver.CallbackResult code, [Optional] Dictionary<string, object> extraMsg)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4A0C880", Offset = "0x4A0B480", VA = "0x184A0C880")]
		private void SendMessageInMain(string methodName, string paramValue)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ImageSaver()
		{
		}

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		private const int CallbackTypeCode = 8;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		private enum FolderType
		{
			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			UserPicturesFolder,
			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			GameInstalledFolder
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		private enum ErrorCode
		{
			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			NotInited,
			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			ParamsError,
			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			ImageNotFound = 3,
			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			ShareChannelError = 6,
			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			SaveFailed = 8,
			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			UnknowError = -1
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		private enum CallbackResult : byte
		{
			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			Success,
			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			Cancelled,
			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			Failed
		}

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		[Preserve]
		public class ImageShareInfo
		{
			// Token: 0x060002BE RID: 702 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ImageShareInfo()
			{
			}

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty("shareChannel")]
			public int shareChannel;

			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty("extraData")]
			public string extraData;

			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty("imgPath")]
			public string imgPath;

			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[JsonProperty("relativePath")]
			public string relativePath;

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[JsonProperty("folderType")]
			public int folderType;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[JsonProperty("title")]
			public string title;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[JsonProperty("desc")]
			public string desc;
		}
	}
}
