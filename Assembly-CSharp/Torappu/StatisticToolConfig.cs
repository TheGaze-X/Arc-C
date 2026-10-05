using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	[CreateAssetMenu(menuName = "Torappu/Tools/Character Statistic Tool Config")]
	public class StatisticToolConfig : ScriptableObject
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001ED")]
		public string filePath
		{
			[Token(Token = "0x6004CCD")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Inspect]
		private void CleanFilesInFolder()
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		[Token(Token = "0x170001EE")]
		public bool recordDataAtStart
		{
			[Token(Token = "0x6004CCF")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		[Token(Token = "0x170001EF")]
		public float disableLogToFileTime
		{
			[Token(Token = "0x6004CD0")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x1793370", Offset = "0x1791F70", VA = "0x181793370")]
		public void SetRecordDataAtStartAndDisableLogToFileTime(bool value, float time)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		// (set) Token: 0x06004CD3 RID: 19667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F0")]
		public bool autoRecordVideo
		{
			[Token(Token = "0x6004CD2")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CD3")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x0002D408 File Offset: 0x0002B608
		[Token(Token = "0x170001F1")]
		public float autoRecordVideoMaxTime
		{
			[Token(Token = "0x6004CD4")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x0002D420 File Offset: 0x0002B620
		[Token(Token = "0x170001F2")]
		public float autoRecordVideoFrameRate
		{
			[Token(Token = "0x6004CD5")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x0002D438 File Offset: 0x0002B638
		[Token(Token = "0x170001F3")]
		public bool bLockGameFrame
		{
			[Token(Token = "0x6004CD6")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x0002D450 File Offset: 0x0002B650
		[Token(Token = "0x170001F4")]
		public bool bRecordAudio
		{
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x0002D468 File Offset: 0x0002B668
		[Token(Token = "0x170001F5")]
		public int autoRecordVideoNumStartDeleteHalf
		{
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x0002D480 File Offset: 0x0002B680
		[Token(Token = "0x170001F6")]
		public int autoRecordVideoTmpNumStartDeleteHalf
		{
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDA")]
		[Address(RVA = "0x1793380", Offset = "0x1791F80", VA = "0x181793380")]
		public StatisticToolConfig()
		{
		}

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _recordDataAtStart;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _disableLogToFileTime;

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _filePath;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private bool _autoRecordVideo;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _autoRecordVideoFolder;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _autoRecordVideoMaxTime;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _frameRate;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _bLockGameFrame;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _bRecordAudio;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _autoRecordVideoNumStartDeleteHalf;

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _autoRecordVideoTmpNumStartDeleteHalf;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x50")]
		public StatisticToolConfig.PathAndPrefix[] pathAndPrefixs;

		// Token: 0x02000492 RID: 1170
		[Token(Token = "0x2000492")]
		public struct PathAndPrefix
		{
			// Token: 0x040010AA RID: 4266
			[Token(Token = "0x40010AA")]
			[FieldOffset(Offset = "0x0")]
			public string path;

			// Token: 0x040010AB RID: 4267
			[Token(Token = "0x40010AB")]
			[FieldOffset(Offset = "0x8")]
			public string prefix;
		}
	}
}
