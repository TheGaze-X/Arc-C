using System;
using System.Text;
using AOT;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	protected static SteamManager Instance
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5BE2930", Offset = "0x5BE1530", VA = "0x185BE2930")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000002")]
	public static bool Initialized
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5BE2840", Offset = "0x5BE1440", VA = "0x185BE2840")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x5BE27E0", Offset = "0x5BE13E0", VA = "0x185BE27E0")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x5BE22A0", Offset = "0x5BE0EA0", VA = "0x185BE22A0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x5BE26C0", Offset = "0x5BE12C0", VA = "0x185BE26C0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x5BE2600", Offset = "0x5BE1200", VA = "0x185BE2600", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x5BE2830", Offset = "0x5BE1430", VA = "0x185BE2830", Slot = "7")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
	public SteamManager()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	protected static bool s_EverInitialized;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x8")]
	protected static SteamManager s_instance;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	protected bool m_bInitialized;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;
}
