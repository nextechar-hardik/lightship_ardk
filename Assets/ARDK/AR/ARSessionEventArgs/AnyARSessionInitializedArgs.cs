// Copyright 2022 Niantic, Inc. All Rights Reserved.

using Niantic.ARDK.Utilities;

namespace Niantic.ARDK.AR.ARSessionEventArgs
{
  public struct AnyARSessionInitializedArgs:
    IArdkEventArgs
  {
    public AnyARSessionInitializedArgs(IARSession session, bool isLocal):
      this()
    {
      Session = session;
      _IsLocal = isLocal;
    }

    public IARSession Session { get; }

    internal bool _IsLocal { get; }
  }
}