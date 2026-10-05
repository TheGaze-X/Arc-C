using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A4F RID: 19023
	[Token(Token = "0x2004A4F")]
	public class HotUpdateProgressModel : IHotfixable
	{
		// Token: 0x0601C98C RID: 117132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C98C")]
		[Address(RVA = "0x160C8B0", Offset = "0x160B4B0", VA = "0x18160C8B0")]
		public string GetHintText()
		{
			return null;
		}

		// Token: 0x0601C98D RID: 117133 RVA: 0x000A8BA0 File Offset: 0x000A6DA0
		[Token(Token = "0x601C98D")]
		[Address(RVA = "0x160C950", Offset = "0x160B550", VA = "0x18160C950")]
		public HotUpdateProgressModel.IconType GetIconType()
		{
			return HotUpdateProgressModel.IconType.NONE;
		}

		// Token: 0x0601C98E RID: 117134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C98E")]
		[Address(RVA = "0x160C9C0", Offset = "0x160B5C0", VA = "0x18160C9C0")]
		public HotUpdateProgressModel()
		{
		}

		// Token: 0x040258BF RID: 153791
		[Token(Token = "0x40258BF")]
		[FieldOffset(Offset = "0x10")]
		public HotUpdateProgressModel.Progress progress;

		// Token: 0x040258C0 RID: 153792
		[Token(Token = "0x40258C0")]
		[FieldOffset(Offset = "0x18")]
		public string hint;

		// Token: 0x040258C1 RID: 153793
		[Token(Token = "0x40258C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHintText;

		// Token: 0x040258C2 RID: 153794
		[Token(Token = "0x40258C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIconType;

		// Token: 0x040258C3 RID: 153795
		[Token(Token = "0x40258C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A50 RID: 19024
		[Token(Token = "0x2004A50")]
		public enum IconType
		{
			// Token: 0x040258C5 RID: 153797
			[Token(Token = "0x40258C5")]
			NONE,
			// Token: 0x040258C6 RID: 153798
			[Token(Token = "0x40258C6")]
			LOADING,
			// Token: 0x040258C7 RID: 153799
			[Token(Token = "0x40258C7")]
			DOWNLOAD
		}

		// Token: 0x02004A51 RID: 19025
		[Token(Token = "0x2004A51")]
		public abstract class Progress
		{
			// Token: 0x0601C98F RID: 117135
			[Token(Token = "0x601C98F")]
			public abstract string GetInfo();

			// Token: 0x0601C990 RID: 117136
			[Token(Token = "0x601C990")]
			public abstract double GetCurrent();

			// Token: 0x0601C991 RID: 117137
			[Token(Token = "0x601C991")]
			public abstract double GetTotal();

			// Token: 0x0601C992 RID: 117138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C992")]
			[Address(RVA = "0x161CFD0", Offset = "0x161BBD0", VA = "0x18161CFD0")]
			protected Progress()
			{
			}

			// Token: 0x040258C8 RID: 153800
			[Token(Token = "0x40258C8")]
			[FieldOffset(Offset = "0x10")]
			public HotUpdateProgressModel.IconType iconType;
		}

		// Token: 0x02004A52 RID: 19026
		[Token(Token = "0x2004A52")]
		public class SimpleProgress : HotUpdateProgressModel.Progress
		{
			// Token: 0x0601C993 RID: 117139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C993")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			public override string GetInfo()
			{
				return null;
			}

			// Token: 0x0601C994 RID: 117140 RVA: 0x000A8BB8 File Offset: 0x000A6DB8
			[Token(Token = "0x601C994")]
			[Address(RVA = "0x161D230", Offset = "0x161BE30", VA = "0x18161D230", Slot = "5")]
			public override double GetCurrent()
			{
				return 0.0;
			}

			// Token: 0x0601C995 RID: 117141 RVA: 0x000A8BD0 File Offset: 0x000A6DD0
			[Token(Token = "0x601C995")]
			[Address(RVA = "0x161D240", Offset = "0x161BE40", VA = "0x18161D240", Slot = "6")]
			public override double GetTotal()
			{
				return 0.0;
			}

			// Token: 0x0601C996 RID: 117142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C996")]
			[Address(RVA = "0x161CFD0", Offset = "0x161BBD0", VA = "0x18161CFD0")]
			public SimpleProgress()
			{
			}

			// Token: 0x040258C9 RID: 153801
			[Token(Token = "0x40258C9")]
			[FieldOffset(Offset = "0x18")]
			public string info;

			// Token: 0x040258CA RID: 153802
			[Token(Token = "0x40258CA")]
			[FieldOffset(Offset = "0x20")]
			public double current;
		}

		// Token: 0x02004A53 RID: 19027
		[Token(Token = "0x2004A53")]
		public class DownloadProgress : HotUpdateProgressModel.Progress
		{
			// Token: 0x0601C997 RID: 117143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C997")]
			[Address(RVA = "0x160C240", Offset = "0x160AE40", VA = "0x18160C240")]
			public DownloadProgress(string downloadInfoFormat)
			{
			}

			// Token: 0x0601C998 RID: 117144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C998")]
			[Address(RVA = "0x160C210", Offset = "0x160AE10", VA = "0x18160C210")]
			public void SetProgress(long curBytes, long totalBytes)
			{
			}

			// Token: 0x0601C999 RID: 117145 RVA: 0x000A8BE8 File Offset: 0x000A6DE8
			[Token(Token = "0x601C999")]
			[Address(RVA = "0x160C0B0", Offset = "0x160ACB0", VA = "0x18160C0B0", Slot = "5")]
			public override double GetCurrent()
			{
				return 0.0;
			}

			// Token: 0x0601C99A RID: 117146 RVA: 0x000A8C00 File Offset: 0x000A6E00
			[Token(Token = "0x601C99A")]
			[Address(RVA = "0x160C200", Offset = "0x160AE00", VA = "0x18160C200", Slot = "6")]
			public override double GetTotal()
			{
				return 0.0;
			}

			// Token: 0x0601C99B RID: 117147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C99B")]
			[Address(RVA = "0x160C0C0", Offset = "0x160ACC0", VA = "0x18160C0C0", Slot = "4")]
			public override string GetInfo()
			{
				return null;
			}

			// Token: 0x040258CB RID: 153803
			[Token(Token = "0x40258CB")]
			[FieldOffset(Offset = "0x18")]
			private string m_info;

			// Token: 0x040258CC RID: 153804
			[Token(Token = "0x40258CC")]
			[FieldOffset(Offset = "0x20")]
			private long m_curBytes;

			// Token: 0x040258CD RID: 153805
			[Token(Token = "0x40258CD")]
			[FieldOffset(Offset = "0x28")]
			private long m_totalBytes;

			// Token: 0x040258CE RID: 153806
			[Token(Token = "0x40258CE")]
			[FieldOffset(Offset = "0x30")]
			private string m_formatCache;
		}
	}
}
