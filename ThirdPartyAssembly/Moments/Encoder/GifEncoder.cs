using System;
using System.IO;
using Il2CppDummyDll;

namespace Moments.Encoder
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class GifEncoder
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x5426430", Offset = "0x5425030", VA = "0x185426430")]
		public GifEncoder()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x54264B0", Offset = "0x54250B0", VA = "0x1854264B0")]
		public GifEncoder(int repeat, int quality)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5425700", Offset = "0x5424300", VA = "0x185425700")]
		public void SetDelay(int ms)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5425730", Offset = "0x5424330", VA = "0x185425730")]
		public void SetFrameRate(float fps)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5424D50", Offset = "0x5423950", VA = "0x185424D50")]
		public void AddFrame(GifFrame frame)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5425770", Offset = "0x5424370", VA = "0x185425770")]
		public void Start(FileStream os)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5425860", Offset = "0x5424460", VA = "0x185425860")]
		public void Start(string file)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x54253F0", Offset = "0x5423FF0", VA = "0x1854253F0")]
		public void Finish()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5425760", Offset = "0x5424360", VA = "0x185425760")]
		protected void SetSize(int w, int h)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x54255B0", Offset = "0x54241B0", VA = "0x1854255B0")]
		protected void GetImagePixels()
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5425210", Offset = "0x5423E10", VA = "0x185425210")]
		protected void AnalyzePixels()
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x5425940", Offset = "0x5424540", VA = "0x185425940")]
		protected void WriteGraphicCtrlExt()
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x5425AF0", Offset = "0x54246F0", VA = "0x185425AF0")]
		protected void WriteImageDesc()
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5425C30", Offset = "0x5424830", VA = "0x185425C30")]
		protected void WriteLSD()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5425D50", Offset = "0x5424950", VA = "0x185425D50")]
		protected void WriteNetscapeExt()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x5425EE0", Offset = "0x5424AE0", VA = "0x185425EE0")]
		protected void WritePalette()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x5425FB0", Offset = "0x5424BB0", VA = "0x185425FB0")]
		protected void WritePixels()
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5426280", Offset = "0x5424E80", VA = "0x185426280")]
		protected void WriteShort(int value)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5426370", Offset = "0x5424F70", VA = "0x185426370")]
		protected void WriteString(string s)
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x10")]
		protected int m_Width;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x14")]
		protected int m_Height;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x18")]
		protected int m_Repeat;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x1C")]
		protected int m_FrameDelay;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_HasStarted;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x28")]
		protected FileStream m_FileStream;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x30")]
		protected GifFrame m_CurrentFrame;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] m_Pixels;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] m_IndexedPixels;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x48")]
		protected int m_ColorDepth;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x50")]
		protected byte[] m_ColorTab;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x58")]
		protected bool[] m_UsedEntry;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x60")]
		protected int m_PaletteSize;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x64")]
		protected int m_DisposalCode;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x68")]
		protected bool m_ShouldCloseStream;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x69")]
		protected bool m_IsFirstFrame;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x6A")]
		protected bool m_IsSizeSet;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x6C")]
		protected int m_SampleInterval;
	}
}
