/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;



public partial class Library : TBase
{
  private List<Track> _Tracks;
  private List<Album> _Albums;
  private List<Playlist> _Playlists;
  private List<ContentCreator> _ContentCreators;

  public short IdLibrary { get; set; }

  public List<Track> Tracks
  {
    get
    {
      return _Tracks;
    }
    set
    {
      __isset.Tracks = true;
      this._Tracks = value;
    }
  }

  public List<Album> Albums
  {
    get
    {
      return _Albums;
    }
    set
    {
      __isset.Albums = true;
      this._Albums = value;
    }
  }

  public List<Playlist> Playlists
  {
    get
    {
      return _Playlists;
    }
    set
    {
      __isset.Playlists = true;
      this._Playlists = value;
    }
  }

  public List<ContentCreator> ContentCreators
  {
    get
    {
      return _ContentCreators;
    }
    set
    {
      __isset.ContentCreators = true;
      this._ContentCreators = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool Tracks;
    public bool Albums;
    public bool Playlists;
    public bool ContentCreators;
  }

  public Library()
  {
    this._Tracks = new List<Track>();
    this.__isset.Tracks = true;
    this._Albums = new List<Album>();
    this.__isset.Albums = true;
    this._Playlists = new List<Playlist>();
    this.__isset.Playlists = true;
    this._ContentCreators = new List<ContentCreator>();
    this.__isset.ContentCreators = true;
  }

  public Library(short idLibrary) : this()
  {
    this.IdLibrary = idLibrary;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_idLibrary = false;
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I16)
            {
              IdLibrary = await iprot.ReadI16Async(cancellationToken);
              isset_idLibrary = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.List)
            {
              {
                TList _list12 = await iprot.ReadListBeginAsync(cancellationToken);
                Tracks = new List<Track>(_list12.Count);
                for(int _i13 = 0; _i13 < _list12.Count; ++_i13)
                {
                  Track _elem14;
                  _elem14 = new Track();
                  await _elem14.ReadAsync(iprot, cancellationToken);
                  Tracks.Add(_elem14);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.List)
            {
              {
                TList _list15 = await iprot.ReadListBeginAsync(cancellationToken);
                Albums = new List<Album>(_list15.Count);
                for(int _i16 = 0; _i16 < _list15.Count; ++_i16)
                {
                  Album _elem17;
                  _elem17 = new Album();
                  await _elem17.ReadAsync(iprot, cancellationToken);
                  Albums.Add(_elem17);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.List)
            {
              {
                TList _list18 = await iprot.ReadListBeginAsync(cancellationToken);
                Playlists = new List<Playlist>(_list18.Count);
                for(int _i19 = 0; _i19 < _list18.Count; ++_i19)
                {
                  Playlist _elem20;
                  _elem20 = new Playlist();
                  await _elem20.ReadAsync(iprot, cancellationToken);
                  Playlists.Add(_elem20);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.List)
            {
              {
                TList _list21 = await iprot.ReadListBeginAsync(cancellationToken);
                ContentCreators = new List<ContentCreator>(_list21.Count);
                for(int _i22 = 0; _i22 < _list21.Count; ++_i22)
                {
                  ContentCreator _elem23;
                  _elem23 = new ContentCreator();
                  await _elem23.ReadAsync(iprot, cancellationToken);
                  ContentCreators.Add(_elem23);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
      if (!isset_idLibrary)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var struc = new TStruct("Library");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "idLibrary";
      field.Type = TType.I16;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await oprot.WriteI16Async(IdLibrary, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if (Tracks != null && __isset.Tracks)
      {
        field.Name = "Tracks";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Tracks.Count), cancellationToken);
          foreach (Track _iter24 in Tracks)
          {
            await _iter24.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Albums != null && __isset.Albums)
      {
        field.Name = "Albums";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Albums.Count), cancellationToken);
          foreach (Album _iter25 in Albums)
          {
            await _iter25.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Playlists != null && __isset.Playlists)
      {
        field.Name = "Playlists";
        field.Type = TType.List;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Playlists.Count), cancellationToken);
          foreach (Playlist _iter26 in Playlists)
          {
            await _iter26.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (ContentCreators != null && __isset.ContentCreators)
      {
        field.Name = "ContentCreators";
        field.Type = TType.List;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, ContentCreators.Count), cancellationToken);
          foreach (ContentCreator _iter27 in ContentCreators)
          {
            await _iter27.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override bool Equals(object that)
  {
    var other = that as Library;
    if (other == null) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(IdLibrary, other.IdLibrary)
      && ((__isset.Tracks == other.__isset.Tracks) && ((!__isset.Tracks) || (TCollections.Equals(Tracks, other.Tracks))))
      && ((__isset.Albums == other.__isset.Albums) && ((!__isset.Albums) || (TCollections.Equals(Albums, other.Albums))))
      && ((__isset.Playlists == other.__isset.Playlists) && ((!__isset.Playlists) || (TCollections.Equals(Playlists, other.Playlists))))
      && ((__isset.ContentCreators == other.__isset.ContentCreators) && ((!__isset.ContentCreators) || (TCollections.Equals(ContentCreators, other.ContentCreators))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + IdLibrary.GetHashCode();
      if(__isset.Tracks)
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Tracks);
      if(__isset.Albums)
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Albums);
      if(__isset.Playlists)
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Playlists);
      if(__isset.ContentCreators)
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ContentCreators);
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("Library(");
    sb.Append(", IdLibrary: ");
    sb.Append(IdLibrary);
    if (Tracks != null && __isset.Tracks)
    {
      sb.Append(", Tracks: ");
      sb.Append(Tracks);
    }
    if (Albums != null && __isset.Albums)
    {
      sb.Append(", Albums: ");
      sb.Append(Albums);
    }
    if (Playlists != null && __isset.Playlists)
    {
      sb.Append(", Playlists: ");
      sb.Append(Playlists);
    }
    if (ContentCreators != null && __isset.ContentCreators)
    {
      sb.Append(", ContentCreators: ");
      sb.Append(ContentCreators);
    }
    sb.Append(")");
    return sb.ToString();
  }
}
