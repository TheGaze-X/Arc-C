using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public class CriAtomExAcb : CriDisposable
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x17000048")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x17000049")]
		public bool isAvailable
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x36BD300", Offset = "0x36BBF00", VA = "0x1836BD300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x36BBE50", Offset = "0x36BAA50", VA = "0x1836BBE50")]
		public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath)
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x36BBB80", Offset = "0x36BA780", VA = "0x1836BBB80")]
		public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath)
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x36BBD10", Offset = "0x36BA910", VA = "0x1836BBD10")]
		public static CriAtomExAcb LoadAcbData(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath)
		{
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x36B9E50", Offset = "0x36B8A50", VA = "0x1836B9E50", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x36B9EB0", Offset = "0x36B8AB0", VA = "0x1836B9EB0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x36BA010", Offset = "0x36B8C10", VA = "0x1836BA010")]
		public bool Exists(string cueName)
		{
			return default(bool);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x36BA0C0", Offset = "0x36B8CC0", VA = "0x1836BA0C0")]
		public bool Exists(int cueId)
		{
			return default(bool);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x36BA960", Offset = "0x36B9560", VA = "0x1836BA960")]
		public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x36BA6E0", Offset = "0x36B92E0", VA = "0x1836BA6E0")]
		public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x36BA340", Offset = "0x36B8F40", VA = "0x1836BA340")]
		public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x36BA5C0", Offset = "0x36B91C0", VA = "0x1836BA5C0")]
		public CriAtomEx.CueInfo[] GetCueInfoList()
		{
			return null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x36BB540", Offset = "0x36BA140", VA = "0x1836BB540")]
		public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x36BB790", Offset = "0x36BA390", VA = "0x1836BB790")]
		public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x36BAC90", Offset = "0x36B9890", VA = "0x1836BAC90")]
		public int GetNumCuePlaying(string name)
		{
			return 0;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x36BAC00", Offset = "0x36B9800", VA = "0x1836BAC00")]
		public int GetNumCuePlaying(int id)
		{
			return 0;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x36BA270", Offset = "0x36B8E70", VA = "0x1836BA270")]
		public int GetBlockIndex(string cueName, string blockName)
		{
			return 0;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x36BA1B0", Offset = "0x36B8DB0", VA = "0x1836BA1B0")]
		public int GetBlockIndex(int cueId, string blockName)
		{
			return 0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x36BAD40", Offset = "0x36B9940", VA = "0x1836BAD40")]
		public int GetNumUsableAisacControls(string cueName)
		{
			return 0;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x36BADF0", Offset = "0x36B99F0", VA = "0x1836BADF0")]
		public int GetNumUsableAisacControls(int cueId)
		{
			return 0;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x36BB310", Offset = "0x36B9F10", VA = "0x1836BB310")]
		public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x36BB0F0", Offset = "0x36B9CF0", VA = "0x1836BB0F0")]
		public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x36BAE80", Offset = "0x36B9A80", VA = "0x1836BAE80")]
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName)
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x36BAFC0", Offset = "0x36B9BC0", VA = "0x1836BAFC0")]
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x36BC0C0", Offset = "0x36BACC0", VA = "0x1836BC0C0")]
		public void ResetCueTypeState(string cueName)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x36BC030", Offset = "0x36BAC30", VA = "0x1836BC030")]
		public void ResetCueTypeState(int cueId)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x36B9940", Offset = "0x36B8540", VA = "0x1836B9940")]
		public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x36B9D60", Offset = "0x36B8960", VA = "0x1836B9D60")]
		public void DetachAwbFile(string awb_name)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x36BBAB0", Offset = "0x36BA6B0", VA = "0x1836BBAB0")]
		public bool IsReadyToRelease()
		{
			return default(bool);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x36BB9C0", Offset = "0x36BA5C0", VA = "0x1836BB9C0")]
		public bool IsAttachedAwbFile(string awbName)
		{
			return default(bool);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x738E30", Offset = "0x737A30", VA = "0x180738E30")]
		public float GetLoadProgress()
		{
			return 0f;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x36B9AD0", Offset = "0x36B86D0", VA = "0x1836B9AD0")]
		public void Decrypt(ulong key, ulong nonce)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x36BC160", Offset = "0x36BAD60", VA = "0x1836BC160")]
		internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x36BA150", Offset = "0x36B8D50", VA = "0x1836BA150", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600034F RID: 847
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x36BD050", Offset = "0x36BBC50", VA = "0x1836BD050")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);

		// Token: 0x06000350 RID: 848
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x36BCF70", Offset = "0x36BBB70", VA = "0x1836BCF70")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);

		// Token: 0x06000351 RID: 849
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x36BD150", Offset = "0x36BBD50", VA = "0x1836BD150")]
		[PreserveSig]
		private static extern void criAtomExAcb_Release(IntPtr acb_hn);

		// Token: 0x06000352 RID: 850
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x36BC9C0", Offset = "0x36BB5C0", VA = "0x1836BC9C0")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn);

		// Token: 0x06000353 RID: 851
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x36BC3C0", Offset = "0x36BAFC0", VA = "0x1836BC3C0")]
		[PreserveSig]
		private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id);

		// Token: 0x06000354 RID: 852
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x36BC450", Offset = "0x36BB050", VA = "0x1836BC450")]
		[PreserveSig]
		private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name);

		// Token: 0x06000355 RID: 853
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x36BCA40", Offset = "0x36BB640", VA = "0x1836BCA40")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id);

		// Token: 0x06000356 RID: 854
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x36BCAD0", Offset = "0x36BB6D0", VA = "0x1836BCAD0")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name);

		// Token: 0x06000357 RID: 855
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x36BCB80", Offset = "0x36BB780", VA = "0x1836BCB80")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info);

		// Token: 0x06000358 RID: 856
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x36BCC30", Offset = "0x36BB830", VA = "0x1836BCC30")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info);

		// Token: 0x06000359 RID: 857
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x36BCCF0", Offset = "0x36BB8F0", VA = "0x1836BCCF0")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info);

		// Token: 0x0600035A RID: 858
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x36BCD90", Offset = "0x36BB990", VA = "0x1836BCD90")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info);

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x36BC7D0", Offset = "0x36BB3D0", VA = "0x1836BC7D0")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info);

		// Token: 0x0600035C RID: 860
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x36BC690", Offset = "0x36BB290", VA = "0x1836BC690")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info);

		// Token: 0x0600035D RID: 861
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x36BC730", Offset = "0x36BB330", VA = "0x1836BC730")]
		[PreserveSig]
		private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info);

		// Token: 0x0600035E RID: 862
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x36BC910", Offset = "0x36BB510", VA = "0x1836BC910")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name);

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x36BC880", Offset = "0x36BB480", VA = "0x1836BC880")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id);

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x36BC500", Offset = "0x36BB100", VA = "0x1836BC500")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name);

		// Token: 0x06000361 RID: 865
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x36BC5C0", Offset = "0x36BB1C0", VA = "0x1836BC5C0")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name);

		// Token: 0x06000362 RID: 866
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x36BD260", Offset = "0x36BBE60", VA = "0x1836BD260")]
		[PreserveSig]
		private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name);

		// Token: 0x06000363 RID: 867
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x36BD1D0", Offset = "0x36BBDD0", VA = "0x1836BD1D0")]
		[PreserveSig]
		private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id);

		// Token: 0x06000364 RID: 868
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x36BC230", Offset = "0x36BAE30", VA = "0x1836BC230")]
		[PreserveSig]
		private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size);

		// Token: 0x06000365 RID: 869
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x36BC320", Offset = "0x36BAF20", VA = "0x1836BC320")]
		[PreserveSig]
		private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name);

		// Token: 0x06000366 RID: 870
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x36BCEF0", Offset = "0x36BBAF0", VA = "0x1836BCEF0")]
		[PreserveSig]
		private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn);

		// Token: 0x06000367 RID: 871
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x36BCE40", Offset = "0x36BBA40", VA = "0x1836BCE40")]
		[PreserveSig]
		private static extern bool criAtomExAcb_IsAttachedAwbFile(IntPtr acbHn, string awbName);

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle dataHandle;
	}
}
