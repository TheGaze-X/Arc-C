using System;
using System.Collections;
using CriWare;
using CriWare.CriMana;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Video
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class SofdecMediaPlayer : AbstractMediaPlayerHolder
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x55AB270", Offset = "0x55A9E70", VA = "0x1855AB270", Slot = "11")]
		public override void AddListener(Action<AbstractMediaPlayerHolder.Status> statusChangeEvent)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x55AB360", Offset = "0x55A9F60", VA = "0x1855AB360")]
		private void Awake()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x55AB840", Offset = "0x55AA440", VA = "0x1855AB840", Slot = "12")]
		public override void RemoveListener(Action<AbstractMediaPlayerHolder.Status> statusChangeEvent)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x55AB4C0", Offset = "0x55AA0C0", VA = "0x1855AB4C0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x55ABF10", Offset = "0x55AAB10", VA = "0x1855ABF10")]
		private void _InitIfActive()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x55AB930", Offset = "0x55AA530", VA = "0x1855AB930", Slot = "7")]
		public override void SetLoop(bool loop)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x55AB520", Offset = "0x55AA120", VA = "0x1855AB520", Slot = "8")]
		public override bool IsAbleToPlay()
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x55AB640", Offset = "0x55AA240", VA = "0x1855AB640", Slot = "6")]
		public override void Play()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x55AC190", Offset = "0x55AAD90", VA = "0x1855AC190")]
		private AbstractMediaPlayerHolder.Status _TweenStatus(Player.Status status)
		{
			return AbstractMediaPlayerHolder.Status.UNKNOWN;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x55AB5B0", Offset = "0x55AA1B0", VA = "0x1855AB5B0")]
		private void OnStatusChanged(Player.Status status)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x55AB9D0", Offset = "0x55AA5D0", VA = "0x1855AB9D0", Slot = "10")]
		protected override void SetPath(string path)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x55AC2A0", Offset = "0x55AAEA0", VA = "0x1855AC2A0")]
		private IEnumerator _WaitUntilStopFinish(Action onFinish)
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x55AC0B0", Offset = "0x55AACB0", VA = "0x1855AC0B0")]
		private void _PrepareMovie(string path)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x55AB430", Offset = "0x55AA030", VA = "0x1855AB430", Slot = "9")]
		public override AbstractMediaPlayerHolder.Status GetCurrentStatus()
		{
			return AbstractMediaPlayerHolder.Status.UNKNOWN;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x55ABDF0", Offset = "0x55AA9F0", VA = "0x1855ABDF0", Slot = "13")]
		public override void SetVolume(float volume)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x55ABE90", Offset = "0x55AAA90", VA = "0x1855ABE90", Slot = "5")]
		public override void Stop()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x55ABC00", Offset = "0x55AA800", VA = "0x1855ABC00", Slot = "14")]
		public override void SetSize(Vector2 size, Vector2 largerSize)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x55AC370", Offset = "0x55AAF70", VA = "0x1855AC370")]
		public SofdecMediaPlayer()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CriManaMovieControllerForUI _moviePlayer;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rect;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _holder;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		private bool m_alreadySetSize;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x38")]
		private Action<AbstractMediaPlayerHolder.Status> m_handlerAction;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachePath;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isCacheLoop;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x58")]
		private MovieInfo m_cacheMovieInfo;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		private static XLua.__XLua_Gen_Delegate0 __Hotfix0_AddListener;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		private static XLua.__XLua_Gen_Delegate1 __Hotfix0_Awake;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private static XLua.__XLua_Gen_Delegate0 __Hotfix0_RemoveListener;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		private static XLua.__XLua_Gen_Delegate1 __Hotfix0_Init;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		private static XLua.__XLua_Gen_Delegate1 __Hotfix0__InitIfActive;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		private static XLua.__XLua_Gen_Delegate2 __Hotfix0_SetLoop;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		private static XLua.__XLua_Gen_Delegate3 __Hotfix0_IsAbleToPlay;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		private static XLua.__XLua_Gen_Delegate1 __Hotfix0_Play;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x40")]
		private static XLua.__XLua_Gen_Delegate4 __Hotfix0__TweenStatus;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x48")]
		private static XLua.__XLua_Gen_Delegate5 __Hotfix0_OnStatusChanged;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x50")]
		private static XLua.__XLua_Gen_Delegate0 __Hotfix0_SetPath;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x58")]
		private static XLua.__XLua_Gen_Delegate6 __Hotfix0__WaitUntilStopFinish;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x60")]
		private static XLua.__XLua_Gen_Delegate0 __Hotfix0__PrepareMovie;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x68")]
		private static XLua.__XLua_Gen_Delegate7 __Hotfix0_GetCurrentStatus;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x70")]
		private static XLua.__XLua_Gen_Delegate8 __Hotfix0_SetVolume;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x78")]
		private static XLua.__XLua_Gen_Delegate1 __Hotfix0_Stop;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x80")]
		private static XLua.__XLua_Gen_Delegate9 __Hotfix0_SetSize;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x88")]
		private static XLua.__XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
