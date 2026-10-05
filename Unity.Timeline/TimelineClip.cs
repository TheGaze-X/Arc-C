using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x58F1400", Offset = "0x58F0000", VA = "0x1858F1400")]
		private void UpgradeToLatestVersion()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x58F1590", Offset = "0x58F0190", VA = "0x1858F1590")]
		internal TimelineClip(TrackAsset parent)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x17000036")]
		public bool hasPreExtrapolation
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x58F1D30", Offset = "0x58F0930", VA = "0x1858F1D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x17000037")]
		public bool hasPostExtrapolation
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x58F1D10", Offset = "0x58F0910", VA = "0x1858F1D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000026E4 File Offset: 0x000008E4
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000038")]
		public double timeScale
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x58F2150", Offset = "0x58F0D50", VA = "0x1858F2150")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x58F28A0", Offset = "0x58F14A0", VA = "0x1858F28A0")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000039")]
		public double start
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x58F2790", Offset = "0x58F1390", VA = "0x1858F2790")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002714 File Offset: 0x00000914
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003A")]
		public double duration
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x56EE680", Offset = "0x56ED280", VA = "0x1856EE680", Slot = "6")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x58F2430", Offset = "0x58F1030", VA = "0x1858F2430")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x1700003B")]
		public double end
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x58F1A60", Offset = "0x58F0660", VA = "0x1858F1A60")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003C")]
		public double clipIn
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x58F1850", Offset = "0x58F0450", VA = "0x1858F1850")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x58F2350", Offset = "0x58F0F50", VA = "0x1858F2350")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003D")]
		public string displayName
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x1700003E")]
		public double clipAssetDuration
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x58F1750", Offset = "0x58F0350", VA = "0x1858F1750")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003F")]
		public AnimationClip curves
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			internal set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000040")]
		private string defaultCurvesName
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x58F1430", Offset = "0x58F0030", VA = "0x1858F1430", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x17000041")]
		public bool hasCurves
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x58F1C80", Offset = "0x58F0880", VA = "0x1858F1C80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000042")]
		public Object asset
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000043")]
		private Object assetOwner
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000044")]
		private TrackAsset targetTrack
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000045")]
		[Obsolete("underlyingAsset property is obsolete. Use asset property instead", true)]
		public Object underlyingAsset
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000046")]
		[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", false)]
		public TrackAsset parentTrack
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x58F2700", Offset = "0x58F1300", VA = "0x1858F2700")]
			set
			{
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
		public TrackAsset GetParentTrack()
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x58F0E50", Offset = "0x58EFA50", VA = "0x1858F0E50")]
		internal void SetParentTrack_Internal(TrackAsset newParentTrack)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000278C File Offset: 0x0000098C
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000047")]
		public double easeInDuration
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x58F1880", Offset = "0x58F0480", VA = "0x1858F1880")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x58F24E0", Offset = "0x58F10E0", VA = "0x1858F24E0")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000027A4 File Offset: 0x000009A4
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000048")]
		public double easeOutDuration
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x58F1950", Offset = "0x58F0550", VA = "0x1858F1950")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x58F25F0", Offset = "0x58F11F0", VA = "0x1858F25F0")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x17000049")]
		[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", true)]
		public double eastOutTime
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x58F1A20", Offset = "0x58F0620", VA = "0x1858F1A20")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x1700004A")]
		public double easeOutTime
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x58F1A20", Offset = "0x58F0620", VA = "0x1858F1A20")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004B")]
		public double blendInDuration
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x58F16F0", Offset = "0x58F02F0", VA = "0x1858F16F0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x58F2230", Offset = "0x58F0E30", VA = "0x1858F2230")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004C")]
		public double blendOutDuration
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x58F1720", Offset = "0x58F0320", VA = "0x1858F1720")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x58F22C0", Offset = "0x58F0EC0", VA = "0x1858F22C0")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004D")]
		public TimelineClip.BlendCurveMode blendInCurveMode
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10")]
			get
			{
				return TimelineClip.BlendCurveMode.Auto;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2B0B050", Offset = "0x2B09C50", VA = "0x182B0B050")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004E")]
		public TimelineClip.BlendCurveMode blendOutCurveMode
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x557C480", Offset = "0x557B080", VA = "0x18557C480")]
			get
			{
				return TimelineClip.BlendCurveMode.Auto;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x557C490", Offset = "0x557B090", VA = "0x18557C490")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x1700004F")]
		public bool hasBlendIn
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x58F1C00", Offset = "0x58F0800", VA = "0x1858F1C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x17000050")]
		public bool hasBlendOut
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x58F1C40", Offset = "0x58F0840", VA = "0x1858F1C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000051")]
		public AnimationCurve mixInCurve
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x58F1D50", Offset = "0x58F0950", VA = "0x1858F1D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x17000052")]
		public float mixInPercentage
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x58F1EE0", Offset = "0x58F0AE0", VA = "0x1858F1EE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x17000053")]
		public double mixInDuration
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x58F1DE0", Offset = "0x58F09E0", VA = "0x1858F1DE0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000054")]
		public AnimationCurve mixOutCurve
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x58F1F00", Offset = "0x58F0B00", VA = "0x1858F1F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x17000055")]
		public double mixOutTime
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x58F2070", Offset = "0x58F0C70", VA = "0x1858F2070")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x17000056")]
		public double mixOutDuration
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x58F1F90", Offset = "0x58F0B90", VA = "0x1858F1F90")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x17000057")]
		public float mixOutPercentage
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x58F2000", Offset = "0x58F0C00", VA = "0x1858F2000")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000028F4 File Offset: 0x00000AF4
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000058")]
		public bool recordable
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x22032F0", Offset = "0x2201EF0", VA = "0x1822032F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2203A90", Offset = "0x2202690", VA = "0x182203A90")]
			internal set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000059")]
		[Obsolete("exposedParameter is deprecated and will be removed in a future release", true)]
		public List<string> exposedParameters
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x58F1A70", Offset = "0x58F0670", VA = "0x1858F1A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x1700005A")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x58F17C0", Offset = "0x58F03C0", VA = "0x1858F17C0")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x58F0A80", Offset = "0x58EF680", VA = "0x1858F0A80")]
		internal int Hash()
		{
			return 0;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x58F0680", Offset = "0x58EF280", VA = "0x1858F0680")]
		public float EvaluateMixOut(double time)
		{
			return 0f;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x58F0520", Offset = "0x58EF120", VA = "0x1858F0520")]
		public float EvaluateMixIn(double time)
		{
			return 0f;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x58F08F0", Offset = "0x58EF4F0", VA = "0x1858F08F0")]
		private static AnimationCurve GetDefaultMixInCurve()
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x58F0920", Offset = "0x58EF520", VA = "0x1858F0920")]
		private static AnimationCurve GetDefaultMixOutCurve()
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x58F0FF0", Offset = "0x58EFBF0", VA = "0x1858F0FF0")]
		public double ToLocalTime(double time)
		{
			return 0.0;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x58F0F80", Offset = "0x58EFB80", VA = "0x1858F0F80")]
		public double ToLocalTimeUnbound(double time)
		{
			return 0.0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x58F0890", Offset = "0x58EF490", VA = "0x1858F0890")]
		internal double FromLocalTimeUnbound(double time)
		{
			return 0.0;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700005B")]
		public AnimationClip animationClip
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x58F15E0", Offset = "0x58F01E0", VA = "0x1858F15E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x58F0CB0", Offset = "0x58EF8B0", VA = "0x1858F0CB0")]
		private static double SanitizeTimeValue(double value, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700005C")]
		public TimelineClip.ClipExtrapolation postExtrapolationMode
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x58F20F0", Offset = "0x58F0CF0", VA = "0x1858F20F0")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x58F2710", Offset = "0x58F1310", VA = "0x1858F2710")]
			internal set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700005D")]
		public TimelineClip.ClipExtrapolation preExtrapolationMode
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x58F2120", Offset = "0x58F0D20", VA = "0x1858F2120")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x58F2750", Offset = "0x58F1350", VA = "0x1858F2750")]
			internal set
			{
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x58F0F60", Offset = "0x58EFB60", VA = "0x1858F0F60")]
		internal void SetPostExtrapolationTime(double time)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x58F0F70", Offset = "0x58EFB70", VA = "0x1858F0F70")]
		internal void SetPreExtrapolationTime(double time)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x58F0B40", Offset = "0x58EF740", VA = "0x1858F0B40")]
		public bool IsExtrapolatedTime(double sequenceTime)
		{
			return default(bool);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x58F0C50", Offset = "0x58EF850", VA = "0x1858F0C50")]
		public bool IsPreExtrapolatedTime(double sequenceTime)
		{
			return default(bool);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x58F0BF0", Offset = "0x58EF7F0", VA = "0x1858F0BF0")]
		public bool IsPostExtrapolatedTime(double sequenceTime)
		{
			return default(bool);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x1700005E")]
		public double extrapolatedStart
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x58F1BE0", Offset = "0x58F07E0", VA = "0x1858F1BE0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x1700005F")]
		public double extrapolatedDuration
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x58F1B00", Offset = "0x58F0700", VA = "0x1858F1B00")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x58F0950", Offset = "0x58EF550", VA = "0x1858F0950")]
		private static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration)
		{
			return 0.0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x58F0430", Offset = "0x58EF030", VA = "0x1858F0430", Slot = "7")]
		public void CreateCurves(string curvesClipName)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4A31680", Offset = "0x4A30280", VA = "0x184A31680", Slot = "12")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x58F1400", Offset = "0x58F0000", VA = "0x1858F1400", Slot = "13")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x58F11A0", Offset = "0x58EFDA0", VA = "0x1858F11A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x58F02E0", Offset = "0x58EEEE0", VA = "0x1858F02E0")]
		public void ConformEaseValues()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x58F01F0", Offset = "0x58EEDF0", VA = "0x1858F01F0")]
		private static double CalculateEasingRatio(double easeIn, double easeOut)
		{
			return 0.0;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void UpdateDirty(double oldValue, double newValue)
		{
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		private const int k_LatestVersion = 1;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ClipCaps kDefaultClipCaps;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x4")]
		public static readonly float kDefaultClipDurationInSeconds;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double kTimeScaleMin;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		public static readonly double kTimeScaleMax;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string kDefaultCurvesName;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly double kMinDuration;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly double kMaxTimeValue;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double m_Start;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double m_ClipIn;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Object m_Asset;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("m_HackDuration")]
		private double m_Duration;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private double m_TimeScale;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TrackAsset m_ParentTrack;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private double m_EaseInDuration;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private double m_EaseOutDuration;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private double m_BlendInDuration;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private double m_BlendOutDuration;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve m_MixInCurve;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve m_MixOutCurve;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TimelineClip.BlendCurveMode m_BlendInCurveMode;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private TimelineClip.BlendCurveMode m_BlendOutCurveMode;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<string> m_ExposedParameterNames;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationClip m_AnimationCurves;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool m_Recordable;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_PostExtrapolationMode;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_PreExtrapolationMode;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private double m_PostExtrapolationTime;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private double m_PreExtrapolationTime;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_DisplayName;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		private enum Versions
		{
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			Initial,
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			ClipInFromGlobalToLocal
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		private static class TimelineClipUpgrade
		{
			// Token: 0x06000107 RID: 263 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x58F01B0", Offset = "0x58EEDB0", VA = "0x1858F01B0")]
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
			{
			}
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		public enum ClipExtrapolation
		{
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			None,
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			Hold,
			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			Loop,
			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			PingPong,
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			Continue
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		public enum BlendCurveMode
		{
			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			Auto,
			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			Manual
		}
	}
}
