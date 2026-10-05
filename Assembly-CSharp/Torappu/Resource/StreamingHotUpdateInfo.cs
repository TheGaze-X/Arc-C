using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x02001741 RID: 5953
	[Token(Token = "0x2001741")]
	public class StreamingHotUpdateInfo : Singleton<StreamingHotUpdateInfo>
	{
		// Token: 0x0600961D RID: 38429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600961D")]
		[Address(RVA = "0x3114830", Offset = "0x3113430", VA = "0x183114830")]
		private StreamingHotUpdateInfo()
		{
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600961E")]
		[Address(RVA = "0x3114640", Offset = "0x3113240", VA = "0x183114640")]
		private string _Path()
		{
			return null;
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600961F")]
		[Address(RVA = "0x31143A0", Offset = "0x3112FA0", VA = "0x1831143A0")]
		public IEnumerator Preload()
		{
			return null;
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x0003A878 File Offset: 0x00038A78
		[Token(Token = "0x6009620")]
		[Address(RVA = "0x3114140", Offset = "0x3112D40", VA = "0x183114140")]
		public bool GetOrLoadImmediately(out HotUpdateInfo info, out Exception error)
		{
			return default(bool);
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009621")]
		[Address(RVA = "0x31146D0", Offset = "0x31132D0", VA = "0x1831146D0")]
		private IEnumerator _PreloadCoroutine()
		{
			return null;
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009622")]
		[Address(RVA = "0x3114780", Offset = "0x3113380", VA = "0x183114780")]
		private IEnumerator _PreloadImpl()
		{
			return null;
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009623")]
		[Address(RVA = "0x3114540", Offset = "0x3113140", VA = "0x183114540")]
		private void _LogStreamingFileError(FileUtil.StreamingResult fileContent)
		{
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009624")]
		[Address(RVA = "0x3114450", Offset = "0x3113050", VA = "0x183114450")]
		private void _LogDeserializeError(Exception e)
		{
		}

		// Token: 0x04008C64 RID: 35940
		[Token(Token = "0x4008C64")]
		[FieldOffset(Offset = "0x10")]
		private string m_path;

		// Token: 0x04008C65 RID: 35941
		[Token(Token = "0x4008C65")]
		[FieldOffset(Offset = "0x18")]
		private HotUpdateInfo m_info;

		// Token: 0x04008C66 RID: 35942
		[Token(Token = "0x4008C66")]
		[FieldOffset(Offset = "0x20")]
		private IEnumerator m_preloadRoutine;

		// Token: 0x04008C67 RID: 35943
		[Token(Token = "0x4008C67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008C68 RID: 35944
		[Token(Token = "0x4008C68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Path;

		// Token: 0x04008C69 RID: 35945
		[Token(Token = "0x4008C69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Preload;

		// Token: 0x04008C6A RID: 35946
		[Token(Token = "0x4008C6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetOrLoadImmediately;

		// Token: 0x04008C6B RID: 35947
		[Token(Token = "0x4008C6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PreloadCoroutine;

		// Token: 0x04008C6C RID: 35948
		[Token(Token = "0x4008C6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PreloadImpl;

		// Token: 0x04008C6D RID: 35949
		[Token(Token = "0x4008C6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LogStreamingFileError;

		// Token: 0x04008C6E RID: 35950
		[Token(Token = "0x4008C6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LogDeserializeError;
	}
}
