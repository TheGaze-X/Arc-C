using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class AnimationState
	{
		// Token: 0x060000AB RID: 171 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5137A0", Offset = "0x5123A0", VA = "0x1805137A0")]
		internal void OnStart(TrackEntry entry)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x339AEC0", Offset = "0x3399AC0", VA = "0x18339AEC0")]
		internal void OnInterrupt(TrackEntry entry)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x312CB60", Offset = "0x312B760", VA = "0x18312CB60")]
		internal void OnEnd(TrackEntry entry)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2585D60", Offset = "0x2584960", VA = "0x182585D60")]
		internal void OnDispose(TrackEntry entry)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x31E4FD0", Offset = "0x31E3BD0", VA = "0x1831E4FD0")]
		internal void OnComplete(TrackEntry entry)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x337D690", Offset = "0x337C290", VA = "0x18337D690")]
		internal void OnEvent(TrackEntry entry, Event e)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B1 RID: 177 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000B2 RID: 178 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000001")]
		public event AnimationState.TrackEntryDelegate Start
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x4E402D0", Offset = "0x4E3EED0", VA = "0x184E402D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x4E406A0", Offset = "0x4E3F2A0", VA = "0x184E406A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000002")]
		public event AnimationState.TrackEntryDelegate Interrupt
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4E40230", Offset = "0x4E3EE30", VA = "0x184E40230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4E40600", Offset = "0x4E3F200", VA = "0x184E40600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000B5 RID: 181 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000B6 RID: 182 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000003")]
		public event AnimationState.TrackEntryDelegate End
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4E400F0", Offset = "0x4E3ECF0", VA = "0x184E400F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x4E404C0", Offset = "0x4E3F0C0", VA = "0x184E404C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000004")]
		public event AnimationState.TrackEntryDelegate Dispose
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x4E40050", Offset = "0x4E3EC50", VA = "0x184E40050")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4E40420", Offset = "0x4E3F020", VA = "0x184E40420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000005")]
		public event AnimationState.TrackEntryDelegate Complete
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x4E3FFB0", Offset = "0x4E3EBB0", VA = "0x184E3FFB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4E40380", Offset = "0x4E3EF80", VA = "0x184E40380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000BB RID: 187 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000006")]
		public event AnimationState.TrackEntryEventDelegate Event
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4E40190", Offset = "0x4E3ED90", VA = "0x184E40190")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4E40560", Offset = "0x4E3F160", VA = "0x184E40560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4E3D780", Offset = "0x4E3C380", VA = "0x184E3D780")]
		public void AssignEventSubscribersFrom(AnimationState src)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4E3B620", Offset = "0x4E3A220", VA = "0x184E3B620")]
		public void AddEventSubscribersFrom(AnimationState src)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4E3FC10", Offset = "0x4E3E810", VA = "0x184E3FC10")]
		public AnimationState(AnimationStateData data)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4E3F840", Offset = "0x4E3E440", VA = "0x184E3F840")]
		public void Update(float delta)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4E3F6F0", Offset = "0x4E3E2F0", VA = "0x184E3F6F0")]
		private bool UpdateMixingFrom(TrackEntry to, float delta)
		{
			return default(bool);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4E3CFC0", Offset = "0x4E3BBC0", VA = "0x184E3CFC0")]
		public bool Apply(Skeleton skeleton)
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4E3BC00", Offset = "0x4E3A800", VA = "0x184E3BC00")]
		public bool ApplyEventTimelinesOnly(Skeleton skeleton)
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4E3C260", Offset = "0x4E3AE60", VA = "0x184E3C260")]
		private float ApplyMixingFrom(TrackEntry to, Skeleton skeleton, MixBlend blend)
		{
			return 0f;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4E3BF80", Offset = "0x4E3AB80", VA = "0x184E3BF80")]
		private float ApplyMixingFromEventTimelinesOnly(TrackEntry to, Skeleton skeleton)
		{
			return 0f;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4E3BA50", Offset = "0x4E3A650", VA = "0x184E3BA50")]
		private void ApplyAttachmentTimeline(AttachmentTimeline timeline, Skeleton skeleton, float time, MixBlend blend, bool attachments)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4E3EDA0", Offset = "0x4E3D9A0", VA = "0x184E3EDA0")]
		private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName, bool attachments)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4E3C9C0", Offset = "0x4E3B5C0", VA = "0x184E3C9C0")]
		private static void ApplyRotateTimeline(RotateTimeline timeline, Skeleton skeleton, float time, float alpha, MixBlend blend, float[] timelinesRotation, int i, bool firstFrame)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4E3E7E0", Offset = "0x4E3D3E0", VA = "0x184E3E7E0")]
		private void QueueEvents(TrackEntry entry, float animationTime)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4E3D9C0", Offset = "0x4E3C5C0", VA = "0x184E3D9C0")]
		public void ClearTracks()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4E3D880", Offset = "0x4E3C480", VA = "0x184E3D880")]
		public void ClearTrack(int trackIndex)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4E3EE20", Offset = "0x4E3DA20", VA = "0x184E3EE20")]
		private void SetCurrent(int index, TrackEntry current, bool interrupt)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4E3EAA0", Offset = "0x4E3D6A0", VA = "0x184E3EAA0")]
		public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4E3EB90", Offset = "0x4E3D790", VA = "0x184E3EB90")]
		public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4E3B130", Offset = "0x4E39D30", VA = "0x184E3B130")]
		public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4E3B220", Offset = "0x4E39E20", VA = "0x184E3B220")]
		public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay)
		{
			return null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4E3F120", Offset = "0x4E3DD20", VA = "0x184E3F120")]
		public TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
		{
			return null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4E3B560", Offset = "0x4E3A160", VA = "0x184E3B560")]
		public TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4E3F1C0", Offset = "0x4E3DDC0", VA = "0x184E3F1C0")]
		public void SetEmptyAnimations(float mixDuration)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4E3E4D0", Offset = "0x4E3D0D0", VA = "0x184E3E4D0")]
		private TrackEntry ExpandToIndex(int index)
		{
			return null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4E3E5A0", Offset = "0x4E3D1A0", VA = "0x184E3E5A0")]
		private TrackEntry NewTrackEntry(int trackIndex, Animation animation, bool loop, TrackEntry last)
		{
			return null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4E3E360", Offset = "0x4E3CF60", VA = "0x184E3E360")]
		private void DisposeNext(TrackEntry entry)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4E3B950", Offset = "0x4E3A550", VA = "0x184E3B950")]
		private void AnimationsChanged()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4E3DEB0", Offset = "0x4E3CAB0", VA = "0x184E3DEB0")]
		private void ComputeHold(TrackEntry entry)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4E3E560", Offset = "0x4E3D160", VA = "0x184E3E560")]
		public TrackEntry GetCurrent(int trackIndex)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4E3D810", Offset = "0x4E3C410", VA = "0x184E3D810")]
		public void ClearListenerNotifications()
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003B")]
		public float TimeScale
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x4E407D0", Offset = "0x4E3F3D0", VA = "0x184E407D0")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003C")]
		public AnimationStateData Data
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x4E40740", Offset = "0x4E3F340", VA = "0x184E40740")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003D")]
		public ExposedList<TrackEntry> Tracks
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4E3F580", Offset = "0x4E3E180", VA = "0x184E3F580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Animation EmptyAnimation;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		internal const int Subsequent = 0;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		internal const int First = 1;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		internal const int HoldSubsequent = 2;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		internal const int HoldFirst = 3;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		internal const int HoldMix = 4;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		internal const int Setup = 1;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		internal const int Current = 2;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		protected AnimationStateData data;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		private readonly ExposedList<TrackEntry> tracks;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x20")]
		private readonly ExposedList<Event> events;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x58")]
		private readonly EventQueue queue;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x60")]
		private readonly HashSet<int> propertyIDs;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x68")]
		private bool animationsChanged;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x6C")]
		private float timeScale;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x70")]
		private int unkeyedState;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x78")]
		private readonly Pool<TrackEntry> trackEntryPool;

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000E4 RID: 228
		[Token(Token = "0x200001D")]
		public delegate void TrackEntryDelegate(TrackEntry trackEntry);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000E8 RID: 232
		[Token(Token = "0x200001E")]
		public delegate void TrackEntryEventDelegate(TrackEntry trackEntry, Event e);
	}
}
