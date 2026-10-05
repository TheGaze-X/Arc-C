using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039F5 RID: 14837
	[Token(Token = "0x20039F5")]
	public class UIEffectHelper : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x060176BA RID: 95930 RVA: 0x000965E8 File Offset: 0x000947E8
		[Token(Token = "0x17003814")]
		public float lifeTime
		{
			[Token(Token = "0x60176BA")]
			[Address(RVA = "0xFC2970", Offset = "0xFC1570", VA = "0x180FC2970")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x060176BB RID: 95931 RVA: 0x00096600 File Offset: 0x00094800
		[Token(Token = "0x17003815")]
		public bool isPlaying
		{
			[Token(Token = "0x60176BB")]
			[Address(RVA = "0xFC28E0", Offset = "0xFC14E0", VA = "0x180FC28E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060176BC RID: 95932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176BC")]
		[Address(RVA = "0xFC21F0", Offset = "0xFC0DF0", VA = "0x180FC21F0")]
		private void Awake()
		{
		}

		// Token: 0x060176BD RID: 95933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176BD")]
		[Address(RVA = "0xFC2690", Offset = "0xFC1290", VA = "0x180FC2690")]
		private void Start()
		{
		}

		// Token: 0x060176BE RID: 95934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176BE")]
		[Address(RVA = "0xFC23A0", Offset = "0xFC0FA0", VA = "0x180FC23A0")]
		public void Play()
		{
		}

		// Token: 0x060176BF RID: 95935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176BF")]
		[Address(RVA = "0xFC2700", Offset = "0xFC1300", VA = "0x180FC2700")]
		public void Stop()
		{
		}

		// Token: 0x060176C0 RID: 95936 RVA: 0x00096618 File Offset: 0x00094818
		[Token(Token = "0x60176C0")]
		[Address(RVA = "0xFC27D0", Offset = "0xFC13D0", VA = "0x180FC27D0")]
		private int _SortCompare(Renderer r1, Renderer r2)
		{
			return 0;
		}

		// Token: 0x060176C1 RID: 95937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176C1")]
		[Address(RVA = "0xFC2880", Offset = "0xFC1480", VA = "0x180FC2880")]
		public UIEffectHelper()
		{
		}

		// Token: 0x0401C4B4 RID: 115892
		[Token(Token = "0x401C4B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _psPrefab;

		// Token: 0x0401C4B5 RID: 115893
		[Token(Token = "0x401C4B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _playAtStart;

		// Token: 0x0401C4B6 RID: 115894
		[Token(Token = "0x401C4B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _playOnUIElem;

		// Token: 0x0401C4B7 RID: 115895
		[Token(Token = "0x401C4B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("loop: -1 auto get: 0")]
		private float _lifeTime;

		// Token: 0x0401C4B8 RID: 115896
		[Token(Token = "0x401C4B8")]
		private const string ROOT_PS_PATH = "static_offset/fixed";

		// Token: 0x0401C4B9 RID: 115897
		[Token(Token = "0x401C4B9")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _effectInst;

		// Token: 0x0401C4BA RID: 115898
		[Token(Token = "0x401C4BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lifeTime;

		// Token: 0x0401C4BB RID: 115899
		[Token(Token = "0x401C4BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x0401C4BC RID: 115900
		[Token(Token = "0x401C4BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C4BD RID: 115901
		[Token(Token = "0x401C4BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C4BE RID: 115902
		[Token(Token = "0x401C4BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401C4BF RID: 115903
		[Token(Token = "0x401C4BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0401C4C0 RID: 115904
		[Token(Token = "0x401C4C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SortCompare;

		// Token: 0x0401C4C1 RID: 115905
		[Token(Token = "0x401C4C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
